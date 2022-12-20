namespace DocumentModel.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public partial class DiagramImpl: ModelElementImpl, Diagram
{
  public DocumentFormat.OpenXml.Vml.Office.Diagram? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Diagram?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramImpl(): base() {}
  
  public DiagramImpl(DocumentFormat.OpenXml.Vml.Office.Diagram openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
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
    get => (System.Int32?)OpenXmlElement?.Style?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.AutoFormat?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Reverse?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.AutoLayout?.Value;
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
    get => (System.Int32?)OpenXmlElement?.ScaleX?.Value;
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
    get => (System.Int32?)OpenXmlElement?.ScaleY?.Value;
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
    get => (System.Int32?)OpenXmlElement?.FontSize?.Value;
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
    get => (System.String?)OpenXmlElement?.ConstrainBounds?.Value;
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
    get => (System.Int32?)OpenXmlElement?.BaseTextScale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BaseTextScale = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  public DocumentModel.Vml.RelationTable? RelationTable
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RelationTable>();
        if (item != null)
          return new DocumentModel.Vml.RelationTableImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RelationTable>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.RelationTableImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
