﻿using System;
using System.Collections.Generic;
using IRegisty;

namespace IRegistryTest
{
    public class clsSample
    {

        private string _SamplePropertyString;
        private int _SamplePropertyInteger;
        private DateTime _SamplePropertyDate;
        private string[] _SamplePropertyArrayOfString;
        private List<string> _SamplePropertyListOfString = new List<string>();
        private Dictionary<string, int> _SamplePropertyDictionaryOfInteger = new Dictionary<string, int>();

        public clsSample()
        {
        }

        public clsSample(string SamplePropertyString, int SamplePropertyInteger, DateTime SamplePropertyDate, string[] SamplePropertyArrayOfString, List<string> SamplePropertyListOfString, Dictionary<string, int> SamplePropertyDictionaryOfInteger)
        {
            _SamplePropertyString = SamplePropertyString;
            _SamplePropertyInteger = SamplePropertyInteger;
            _SamplePropertyDate = SamplePropertyDate;
            _SamplePropertyArrayOfString = SamplePropertyArrayOfString;
            _SamplePropertyListOfString = SamplePropertyListOfString;
            _SamplePropertyDictionaryOfInteger = SamplePropertyDictionaryOfInteger;
        }

        [RegistrySerializer(false, "SamplePropertyStringAlias")]
        public string SamplePropertyString
        {
            get { return _SamplePropertyString; }
            set { _SamplePropertyString = value; }
        }

        [RegistrySerializer(false)]
        public int SamplePropertyInteger
        {
            get { return _SamplePropertyInteger; }
            set { _SamplePropertyInteger = value; }
        }

        public DateTime SamplePropertyDate
        {
            get { return _SamplePropertyDate; }
            set { _SamplePropertyDate = value; }
        }

        [RegistrySerializer(false, "SamplePropertyArrayOfStringAlias")]
        public string[] SamplePropertyArrayOfString
        {
            get { return _SamplePropertyArrayOfString; }
            set { _SamplePropertyArrayOfString = value; }
        }

        [RegistrySerializer(false, "SamplePropertyListOfStringAlias")]
        public List<string> SamplePropertyListOfString
        {
            get { return _SamplePropertyListOfString; }
            set { _SamplePropertyListOfString = value; }
        }

        public Dictionary<string, int> SamplePropertyDictionaryOfInteger
        {
            get { return _SamplePropertyDictionaryOfInteger; }
            set { _SamplePropertyDictionaryOfInteger = value; }
        }
    }
}