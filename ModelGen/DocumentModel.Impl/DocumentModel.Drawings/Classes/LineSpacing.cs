namespace DocumentModel.Drawings;

/// <summary>
/// Line Spacing.
/// </summary>
public class LineSpacingImpl: DocumentModel.Drawings.TextSpacingTypeImpl, LineSpacing
{
  public new DocumentFormat.OpenXml.Drawing.LineSpacing? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineSpacing?)_OpenXmlElement;
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
