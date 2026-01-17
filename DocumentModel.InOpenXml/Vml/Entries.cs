namespace DocumentModel.Vml;

public class Entries: ElementCollection<Entry>
{
  protected override object? GetUpdatableOpenXmlElement()
  {
    throw new NotImplementedException();
  }
}