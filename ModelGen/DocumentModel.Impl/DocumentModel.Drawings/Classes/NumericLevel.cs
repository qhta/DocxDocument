namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumericLevel Class.
/// </summary>
public class NumericLevelImpl: ModelElementImpl, NumericLevel
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? PtCount
  {
    get => (UInt32?)OpenXmlElement?.PtCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PtCount = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public String? FormatCode
  {
    get => (String?)OpenXmlElement?.FormatCode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FormatCode = (System.String?)value;
    }
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  public Collection<NumericValue2>? NumericValues
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
