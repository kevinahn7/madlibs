using System;
namespace MadLibs.Models
{
    public class WordVariables
    {
        private string _name;
        private string _adjOne;
        private string _verbOne;
        private string _nounOne;
        private string _verbTwo;
        private string _nounTwo;
        private string _verbThree;
        private string _nounThree;
        private string _adverb;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetAdjOne()
        {
            return _adjOne;
        }

        public void SetAdjOne(string newAdj)
        {
            _adjOne = newAdj;
        }

        public string GetVerbOne()
        {
            return _verbOne;
        }

        public void SetVerbOne(string newVerb)
        {
            _verbOne = newVerb;
        }

        public string GetNounOne()
        {
            return _nounOne;
        }

        public void SetNounOne(string newNoun)
        {
            _nounOne = newNoun;
        }

        public string GetVerbTwo()
        {
            return _verbTwo;
        }

        public void SetVerbTwo(string newVerb)
        {
            _verbTwo = newVerb;
        }

        public string GetNounTwo()
        {
            return _nounTwo;
        }

        public void SetNounTwo(string newNoun)
        {
            _nounTwo = newNoun;
        }

        public string GetVerbThree()
        {
            return _verbThree;
        }

        public void SetVerbThree(string newVerb)
        {
            _verbThree = newVerb;
        }

        public string GetNounThree()
        {
            return _nounThree;
        }

        public void SetNounThree(string newNoun)
        {
            _nounThree = newNoun;
        }

        public string GetAdverb()
        {
            return _adverb;
        }

        public void SetAdverb(string newAdverb)
        {
            _adverb = newAdverb;
        }
    }
}
