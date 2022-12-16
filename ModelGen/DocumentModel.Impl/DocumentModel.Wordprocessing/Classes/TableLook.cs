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
  public DocumentModel.HexBinary? Val
  {
    get
    {
      if (OpenXmlElement?.Val?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.Val.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Val = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Val = null;
      }
    }
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstRow
  {
    get => (System.Boolean?)OpenXmlElement?.FirstRow?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.LastRow?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.FirstColumn?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.LastColumn?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.NoHorizontalBand?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.NoVerticalBand?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoVerticalBand = (System.Boolean?)value;
    }
  }
  
}
