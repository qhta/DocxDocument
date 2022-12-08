namespace DocumentModel.Drawings;

/// <summary>
/// Space Before.
/// </summary>
public class SpaceBeforeImpl: DocumentModel.Drawings.TextSpacingTypeImpl, SpaceBefore
{
  public new DocumentFormat.OpenXml.Drawing.SpaceBefore? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.SpaceBefore?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override Int32? SpacingPercent
  {
    get;
    set;
  }
  
  public override Int32? SpacingPoints
  {
    get;
    set;
  }
  
}
