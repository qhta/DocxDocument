namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
public class ErrorBarsImpl: ModelElementImpl, ErrorBars
{
  public DocumentFormat.OpenXml.Drawing.Charts.ErrorBars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ErrorBars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ErrorBarsImpl(): base() {}
  
  public ErrorBarsImpl(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  public DocumentModel.Drawings.Charts.ErrorBarDirectionKind? ErrorDirection
  {
    get => (DocumentModel.Drawings.Charts.ErrorBarDirectionKind?)OpenXmlElement?.ErrorDirection?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ErrorDirection != null)
        {
          if (value is not null)
            OpenXmlElement.ErrorDirection.Val = (DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues?)value;
          else
            OpenXmlElement.ErrorDirection = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ErrorDirection = new DocumentFormat.OpenXml.Drawing.Charts.ErrorDirection{ Val = (DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  public DocumentModel.Drawings.Charts.ErrorBarKind? ErrorBarType
  {
    get => (DocumentModel.Drawings.Charts.ErrorBarKind?)OpenXmlElement?.ErrorBarType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ErrorBarType != null)
        {
          if (value is not null)
            OpenXmlElement.ErrorBarType.Val = (DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues?)value;
          else
            OpenXmlElement.ErrorBarType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ErrorBarType = new DocumentFormat.OpenXml.Drawing.Charts.ErrorBarType{ Val = (DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  public DocumentModel.Drawings.Charts.ErrorKind? ErrorBarValueType
  {
    get => (DocumentModel.Drawings.Charts.ErrorKind?)OpenXmlElement?.ErrorBarValueType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ErrorBarValueType != null)
        {
          if (value is not null)
            OpenXmlElement.ErrorBarValueType.Val = (DocumentFormat.OpenXml.Drawing.Charts.ErrorValues?)value;
          else
            OpenXmlElement.ErrorBarValueType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ErrorBarValueType = new DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValueType{ Val = (DocumentFormat.OpenXml.Drawing.Charts.ErrorValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  public Boolean? NoEndCap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NoEndCap>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NoEndCap>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.NoEndCap();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Plus.
  /// </summary>
  public DocumentModel.Drawings.Charts.Plus? Plus
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Minus.
  /// </summary>
  public DocumentModel.Drawings.Charts.Minus? Minus
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  public Double? ErrorBarValue
  {
    get => (System.Double?)OpenXmlElement?.ErrorBarValue?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ErrorBarValue != null)
        {
          if (value is not null)
            OpenXmlElement.ErrorBarValue.Val = (System.Double?)value;
          else
            OpenXmlElement.ErrorBarValue = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ErrorBarValue = new DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValue{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
