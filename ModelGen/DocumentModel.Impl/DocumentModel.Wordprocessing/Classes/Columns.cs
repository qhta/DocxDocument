namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Columns Class.
/// </summary>
public class ColumnsImpl: ModelElementImpl, Columns
{
  public DocumentFormat.OpenXml.Wordprocessing.Columns? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Columns?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Equal Column Widths
  /// </summary>
  public Boolean? EqualWidth
  {
    get => (Boolean?)OpenXmlElement?.EqualWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EqualWidth = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Spacing Between Equal Width Columns
  /// </summary>
  public String? Space
  {
    get => (String?)OpenXmlElement?.Space?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Space = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Number of Equal Width Columns
  /// </summary>
  public Int16? ColumnCount
  {
    get => (Int16?)OpenXmlElement?.ColumnCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColumnCount = (System.Int16?)value;
    }
  }
  
  /// <summary>
  /// Draw Line Between Columns
  /// </summary>
  public Boolean? Separator
  {
    get => (Boolean?)OpenXmlElement?.Separator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Separator = (System.Boolean?)value;
    }
  }
  
  public Collection<Column>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
