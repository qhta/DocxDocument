namespace DocumentModel;
/// <summary>
///   Defines the ColorType Class.
/// </summary>
public class ColorType: ModelElement, IColor
{
  protected override object? GetUpdatableOpenXmlElement()
  {
    throw new NotImplementedException();
  }
}