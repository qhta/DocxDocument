namespace DocumentModel.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public class DiagramImpl: ModelElementImpl, Diagram
{
  public DocumentFormat.OpenXml.Vml.Office.Diagram? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Diagram?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get => (ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Diagram Style Options
  /// </summary>
  public Int32? Style
  {
    get => (Int32?)OpenXmlElement?.Style?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Style = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Diagram Automatic Format
  /// </summary>
  public Boolean? AutoFormat
  {
    get => (Boolean?)OpenXmlElement?.AutoFormat?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AutoFormat = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Diagram Reverse Direction
  /// </summary>
  public Boolean? Reverse
  {
    get => (Boolean?)OpenXmlElement?.Reverse?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Reverse = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Diagram Automatic Layout
  /// </summary>
  public Boolean? AutoLayout
  {
    get => (Boolean?)OpenXmlElement?.AutoLayout?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AutoLayout = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Diagram Layout X Scale
  /// </summary>
  public Int32? ScaleX
  {
    get => (Int32?)OpenXmlElement?.ScaleX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ScaleX = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Diagram Layout Y Scale
  /// </summary>
  public Int32? ScaleY
  {
    get => (Int32?)OpenXmlElement?.ScaleY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ScaleY = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Diagram Font Size
  /// </summary>
  public Int32? FontSize
  {
    get => (Int32?)OpenXmlElement?.FontSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FontSize = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Diagram Layout Extents
  /// </summary>
  public String? ConstrainBounds
  {
    get => (String?)OpenXmlElement?.ConstrainBounds?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConstrainBounds = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Diagram Base Font Size
  /// </summary>
  public Int32? BaseTextScale
  {
    get => (Int32?)OpenXmlElement?.BaseTextScale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BaseTextScale = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  public RelationTable? RelationTable
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
