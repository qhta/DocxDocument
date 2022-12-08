namespace DocumentModel.Drawings;

/// <summary>
/// Space After.
/// </summary>
public class SpaceAfterImpl: DocumentModel.Drawings.TextSpacingTypeImpl, SpaceAfter
{
  public new DocumentFormat.OpenXml.Drawing.SpaceAfter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.SpaceAfter?)_OpenXmlElement;
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
