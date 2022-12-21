using System;
using System.Collections.Generic;

namespace DocxDocument.Reader.Test
{
  class Program
  {
    static void NoMain(string[] args)
    {
      var testInstance = new TestProperties();
      testInstance.Setup();
      testInstance.TestCustomProperties();
    }
  }
}
