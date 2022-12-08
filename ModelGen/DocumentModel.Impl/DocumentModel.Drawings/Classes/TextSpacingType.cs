namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextSpacingType Class.
/// </summary>
public class TextSpacingTypeImpl: ModelElementImpl, TextSpacingType
{
  public DocumentFormat.OpenXml.Drawing.TextSpacingType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TextSpacingType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Spacing Percent.
  /// </summary>
  public virtual Int32? SpacingPercent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Spacing Points.
  /// </summary>
  public virtual Int32? SpacingPoints
  {
    get;
    set;
  }
  
}
