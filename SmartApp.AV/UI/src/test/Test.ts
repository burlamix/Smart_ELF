import { ElfUI, ElfUIFactory } from '../ui/ElfUI';
import { BaseEventReader } from '../reader/EventReader'
import { IEmotion, Emotion } from '../emotion/Emotion';
import { ElfUIEvent, KEY_CONTENT, KEY_EMOTION } from '../ui/event/ElfUIEvent';
import { UIWidget, UIWidgetFactory } from '../ui/widget/UIWidget'
import { Point } from '../utils/Point';

export class TestUI extends ElfUI {

	constructor(rootElement: HTMLElement) {
		super(rootElement);
	}

	public onCreateView(root: HTMLElement) {
		this.getRootElement().innerHTML = this.getTemplate();
	}

	public onEmotionChanged(e: IEmotion): void {
		console.log("onEmotionChanged", e);

		this.getRootElement().style.backgroundColor = e.getColor();
	}

	public onPositionChanged(p: Point): void {
		console.log("onPositionChanged", p);
	}

	public onContentChanged(e: Array<UIWidget>): void {
		console.log("onContentChanged", e);
	}

	public getTemplate(): string {
		return "<div>TEST</div>";
	}

	public getContentFactory(): UIWidgetFactory {
		return null;
	}
}

export class TestUIFactory implements ElfUIFactory {

	constructor(private root: HTMLElement) { }

	create(): ElfUI {
		return new TestUI(this.root);
	}
}

export class TestEventReader extends BaseEventReader {
	count = 0;

	private events: Array<ElfUIEvent> = []

	constructor(private delay: number = 0) {
		super();

		let e1 = new ElfUIEvent()
			.putAny(KEY_EMOTION, new Emotion(-0.7, 0.4)) // Anger
			.putAny(KEY_CONTENT, { "speech": { "text": "We should be Anger...", emotion: new Emotion(0, 0) } })

		let e2 = new ElfUIEvent()
			.putAny(KEY_EMOTION, new Emotion(-0.7, 0.1)) // Disgust
			.putAny(KEY_CONTENT, { "speech": { "text": "We should be Disgust...", emotion: new Emotion(0, 0) } })

		let e3 = new ElfUIEvent()
			.putAny(KEY_EMOTION, new Emotion(-0.5, 0.7)) // Fear
			.putAny(KEY_CONTENT, { "speech": { "text": "We should be Fear...", emotion: new Emotion(0, 0) } })

		let e4 = new ElfUIEvent()
			.putAny(KEY_EMOTION, new Emotion(0.7, 0.3)) // Joy
			.putAny(KEY_CONTENT, { "speech": { "text": "We should be Joy...", emotion: new Emotion(0, 0) } })

		let e5 = new ElfUIEvent()
			.putAny(KEY_EMOTION, new Emotion(-0.7, -0.5)) // Sadness
			.putAny(KEY_CONTENT, { "speech": { "text": "We should be Sadness...", emotion: new Emotion(0, 0) } })

		let e6 = new ElfUIEvent()
			.putAny(KEY_EMOTION, new Emotion(0.6, 0.9)) // Surprise
			.putAny(KEY_CONTENT, { "speech": { "text": "We should be Surprise...", emotion: new Emotion(0, 0) } })

		this.events.push(e1)
		this.events.push(e2)
		this.events.push(e3)
		this.events.push(e4)
		this.events.push(e5)
		this.events.push(e6)
	}

	private nextEvent(): ElfUIEvent {
		let e = this.events[this.count];
		this.count = (this.count + 1) % this.events.length;
		return e;
	}

	public start() {
		let handler = () => {
			let e = this.nextEvent();

			this.listener.onEvent(e);

			setTimeout(handler, this.delay);
		};

		setTimeout(handler, this.delay);
	}
}