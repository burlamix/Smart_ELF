import { Builder } from './ui/ElfUI';
import { ElfColorfulUIFactory } from './ui/colorful/ElfColorfulUI';
import { KBEventReader } from './kb/KBEventReader';
import { TTSEventReader } from './tts/TTSEventReader';

let elem = document.getElementById("content");

let factory = new ElfColorfulUIFactory(elem, window);

let kbEventReader = new KBEventReader();
let readers = [
	// new Test.TestEventReader(1000),
	// new KBEventReader.KBEventReader(),
	kbEventReader,
	new TTSEventReader()
];

let ui = new Builder(factory)
	.setEventReaders(readers)
	.build();

readers.forEach(reader => {
	reader.start();
});