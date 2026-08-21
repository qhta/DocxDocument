namespace DocumentModel.Wordprocessing;

public partial class Run: IXmlSerializable
{
  protected override void ReadItems(XmlReader reader)
  {
    base.ReadItems(reader);
    var text = GetText();
    Debug.WriteLine($"Deserialized text: {text}");
  }

}