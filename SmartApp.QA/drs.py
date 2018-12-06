from nltk.parse import load_parser
from nltk.sem.drt import DrtParser
from nltk import *

def f(s,p,debug="no"):
    res = []

    #remove punctuation ad go lowercase

    parser = load_parser(p, trace=0, logic_parser=DrtParser())
    #NotImlementedError
    try:
        for tree in parser.parse(s.split()):
            if(debug == "yes"):
                res.append(str(tree))
            elif(debug == "no"):
                res.append(str(tree.label()['SEM'].simplify()))
    #if we have a failure in the parser tree, return false
    except Exception():
        return False

    #otherwise return our result
    DRS= res[0]

    #TODO write DRS tuple to KB

    return True