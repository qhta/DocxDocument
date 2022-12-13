namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ConditionalFormatStyle Class.
/// </summary>
public class ConditionalFormatStyleImpl: ModelElementImpl, ConditionalFormatStyle
{
  public DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ConditionalFormatStyleImpl(): base() {}
  
  public ConditionalFormatStyleImpl(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Conditional Formatting Bit Mask
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
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
  /// oddVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? OddVerticalBand
  {
    get => (System.Boolean?)OpenXmlElement?.OddVerticalBand?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OddVerticalBand = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// evenVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? EvenVerticalBand
  {
    get => (System.Boolean?)OpenXmlElement?.EvenVerticalBand?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EvenVerticalBand = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// oddHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? OddHorizontalBand
  {
    get => (System.Boolean?)OpenXmlElement?.OddHorizontalBand?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OddHorizontalBand = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// evenHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? EvenHorizontalBand
  {
    get => (System.Boolean?)OpenXmlElement?.EvenHorizontalBand?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EvenHorizontalBand = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// firstRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstRowFirstColumn
  {
    get => (System.Boolean?)OpenXmlElement?.FirstRowFirstColumn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstRowFirstColumn = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// firstRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstRowLastColumn
  {
    get => (System.Boolean?)OpenXmlElement?.FirstRowLastColumn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstRowLastColumn = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// lastRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastRowFirstColumn
  {
    get => (System.Boolean?)OpenXmlElement?.LastRowFirstColumn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastRowFirstColumn = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// lastRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastRowLastColumn
  {
    get => (System.Boolean?)OpenXmlElement?.LastRowLastColumn?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastRowLastColumn = (System.Boolean?)value;
    }
  }
  
}
