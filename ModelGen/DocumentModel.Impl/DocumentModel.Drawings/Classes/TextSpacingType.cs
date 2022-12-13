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
  
  public TextSpacingTypeImpl(): base() {}
  
  public TextSpacingTypeImpl(DocumentFormat.OpenXml.Drawing.TextSpacingType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Spacing Percent.
  /// </summary>
  public virtual Int32? SpacingPercent
  {
    get => (System.Int32?)OpenXmlElement?.SpacingPercent?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SpacingPercent != null)
        {
          if (value is not null)
            OpenXmlElement.SpacingPercent.Val = (System.Int32?)value;
          else
            OpenXmlElement.SpacingPercent = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SpacingPercent = new DocumentFormat.OpenXml.Drawing.SpacingPercent{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Spacing Points.
  /// </summary>
  public virtual Int32? SpacingPoints
  {
    get => (System.Int32?)OpenXmlElement?.SpacingPoints?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SpacingPoints != null)
        {
          if (value is not null)
            OpenXmlElement.SpacingPoints.Val = (System.Int32?)value;
          else
            OpenXmlElement.SpacingPoints = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SpacingPoints = new DocumentFormat.OpenXml.Drawing.SpacingPoints{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
}
