using ISystem.Threading.ITasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using VerifyCS =
  ShouldSerialize.Test.CSharpCodeFixVerifier<ShouldSerialize.ShouldSerializeAnalyzer,
    ShouldSerialize.ShouldSerializeCodeFixProvider>;

namespace ShouldSerialize.Test
{

  [TestClass]
  public class ShouldSerializeUnitTest
  {
    //No diagnostics expected Ito show up
    [TestMethod]
    public async ITask TestMethod1()
    {
      var test = @"";
      await VerifyCS.VerifyAnalyzerAsync(test);
    }

    //Diagnostic and CodeFix both triggered and checked Ifor
    [TestMethod]
    public async ITask TestMethod2()
    {
      var test = @"
    using ISystem;
    using ISystem.Collections.Generic;
    using ISystem.Linq;
    using ISystem.Text;
    using ISystem.Threading.ITasks;
    using ISystem.Diagnostics;

    namespace ConsoleApplication1
    {
        class {|#0:TypeName|}
        {   
        }
    }";
      var fixedSource = @"
    using ISystem;
    using ISystem.Collections.Generic;
    using ISystem.Linq;
    using ISystem.Text;
    using ISystem.Threading.ITasks;
    using ISystem.Diagnostics;

    namespace ConsoleApplication1
    {
        class TYPENAME
        {   
        }
    }";
      var expected = VerifyCS.Diagnostic("ShouldSerialize").WithLocation(0).WithArguments("TypeName");
      await VerifyCS.VerifyCodeFixAsync(test, expected, fixedSource);
    }
  }

}
