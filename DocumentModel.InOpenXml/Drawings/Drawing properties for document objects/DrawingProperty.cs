namespace DocumentModel.Drawings;
/// <summary>
///   Abstract base class for drawing properties.
/// </summary>
public class DrawingProperty: CollectionItem
{
  protected override object? GetUpdatableOpenXmlElement()
  {
    throw new NotImplementedException();
  }
}