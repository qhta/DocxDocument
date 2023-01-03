using System;
using System.Collections.Generic;

namespace DocxDocument.Reader.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      var testInstance = new TestVariants();
      testInstance.Setup();
      testInstance.TestXmlArrayVariantSerialization();
      Console.WriteLine("Test passed");
    }
  }
}
