using System;
using System.Collections.Generic;

namespace DocxDocument.Reader.Test
{
  class Program
  {
    static void NoMain(string[] args)
    {
      var testInstance = new TestReader_ReadProperties();
      testInstance.Setup();
      testInstance.TestCustomProperties();
    }
  }
}
