namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLook Class.
/// </summary>
public class TableLookImpl: ModelElementImpl, TableLook
{
  public DocumentFormat.OpenXml.Wordprocessing.TableLook? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableLook?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableLookImpl(): base() {}
  
  public TableLookImpl(DocumentFormat.OpenXml.Wordprocessing.TableLook openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// val
  /// </summary>
  public DocumentModel.HexBinaryValue? Val
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstRow
  {
    get => (Boolean?)OpenXmlElement?.FirstRow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstRow = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastRow
  {
    get => (Boolean?)OpenXmlElement?.LastRow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastRow = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstColumn
  {
    get => (Boolean?)OpenXmlElement?.FirstColumn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstColumn = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastColumn
  {
    get => (Boolean?)OpenXmlElement?.LastColumn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastColumn = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoHorizontalBand
  {
    get => (Boolean?)OpenXmlElement?.NoHorizontalBand?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoHorizontalBand = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoVerticalBand
  {
    get => (Boolean?)OpenXmlElement?.NoVerticalBand?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoVerticalBand = (System.Boolean?)value;
    }
  }
  
}
