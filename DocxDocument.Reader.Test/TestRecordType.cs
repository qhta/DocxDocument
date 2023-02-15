using DocumentModel.Wordprocessing;

using Qhta.Xml.Serialization;
using System.Reflection;

namespace DocxDocument.Reader.Test;

public class TestRecordType : TestBase
{
  record Data
  {
    public string? Name {get; set;}
  }

  [Test]
  public void TestRecord()
  {
    var A = new Data{Name = "A"};
    var B = A with { };
    B.Name = "B";
    Assert.That(A, Is.Not.EqualTo(B), $"A is different from B");

  }
}
