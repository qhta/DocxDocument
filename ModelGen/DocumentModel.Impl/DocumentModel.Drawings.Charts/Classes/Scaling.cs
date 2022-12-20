namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Scaling.
/// </summary>
public partial class ScalingImpl: ModelElementImpl, Scaling
{
  public DocumentFormat.OpenXml.Drawing.Charts.Scaling? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Scaling?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScalingImpl(): base() {}
  
  public ScalingImpl(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  public Double? LogBase
  {
    get => (System.Double?)OpenXmlElement?.LogBase?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LogBase != null)
        {
          if (value is not null)
            OpenXmlElement.LogBase.Val = (System.Double?)value;
          else
            OpenXmlElement.LogBase = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LogBase = new DocumentFormat.OpenXml.Drawing.Charts.LogBase{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  public DocumentModel.Drawings.Charts.OrientationKind? Orientation
  {
    get => (DocumentModel.Drawings.Charts.OrientationKind?)OpenXmlElement?.Orientation?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Orientation != null)
        {
          if (value is not null)
            OpenXmlElement.Orientation.Val = (DocumentFormat.OpenXml.Drawing.Charts.OrientationValues?)value;
          else
            OpenXmlElement.Orientation = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Orientation = new DocumentFormat.OpenXml.Drawing.Charts.Orientation{ Val = (DocumentFormat.OpenXml.Drawing.Charts.OrientationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  public Double? MaxAxisValue
  {
    get => (System.Double?)OpenXmlElement?.MaxAxisValue?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MaxAxisValue != null)
        {
          if (value is not null)
            OpenXmlElement.MaxAxisValue.Val = (System.Double?)value;
          else
            OpenXmlElement.MaxAxisValue = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MaxAxisValue = new DocumentFormat.OpenXml.Drawing.Charts.MaxAxisValue{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  public Double? MinAxisValue
  {
    get => (System.Double?)OpenXmlElement?.MinAxisValue?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MinAxisValue != null)
        {
          if (value is not null)
            OpenXmlElement.MinAxisValue.Val = (System.Double?)value;
          else
            OpenXmlElement.MinAxisValue = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MinAxisValue = new DocumentFormat.OpenXml.Drawing.Charts.MinAxisValue{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
