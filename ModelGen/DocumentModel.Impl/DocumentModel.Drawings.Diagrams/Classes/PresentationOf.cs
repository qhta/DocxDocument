namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Presentation Of.
/// </summary>
public partial class PresentationOfImpl: ModelElementImpl, PresentationOf
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PresentationOfImpl(): base() {}
  
  public PresentationOfImpl(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? Axis
  {
    get
    {
      if (OpenXmlElement?.Axis != null)
        return new DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>(OpenXmlElement.Axis.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Axis = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>(value.Items.Select(item => new DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>((DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues)item)));
    else
      OpenXmlElement.Axis = null;
      }
    }
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? PointType
  {
    get
    {
      if (OpenXmlElement?.PointType != null)
        return new DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>(OpenXmlElement.PointType.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.PointType = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>(value.Items.Select(item => new DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>((DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues)item)));
    else
      OpenXmlElement.PointType = null;
      }
    }
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public DocumentModel.ListOf<System.Boolean>? HideLastTrans
  {
    get
    {
      if (OpenXmlElement?.HideLastTrans != null)
        return new DocumentModel.ListOf<System.Boolean>(OpenXmlElement.HideLastTrans.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.HideLastTrans = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.BooleanValue>(value.Items.Select(item => new DocumentFormat.OpenXml.BooleanValue(item)));
    else
      OpenXmlElement.HideLastTrans = null;
      }
    }
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public DocumentModel.ListOf<System.Int32>? Start
  {
    get
    {
      if (OpenXmlElement?.Start != null)
        return new DocumentModel.ListOf<System.Int32>(OpenXmlElement.Start.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Start = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.Int32Value>(value.Items.Select(item => new DocumentFormat.OpenXml.Int32Value(item)));
    else
      OpenXmlElement.Start = null;
      }
    }
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public DocumentModel.ListOf<System.UInt32>? Count
  {
    get
    {
      if (OpenXmlElement?.Count != null)
        return new DocumentModel.ListOf<System.UInt32>(OpenXmlElement.Count.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Count = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.UInt32Value>(value.Items.Select(item => new DocumentFormat.OpenXml.UInt32Value(item)));
    else
      OpenXmlElement.Count = null;
      }
    }
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public DocumentModel.ListOf<System.Int32>? Step
  {
    get
    {
      if (OpenXmlElement?.Step != null)
        return new DocumentModel.ListOf<System.Int32>(OpenXmlElement.Step.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Step = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.Int32Value>(value.Items.Select(item => new DocumentFormat.OpenXml.Int32Value(item)));
    else
      OpenXmlElement.Step = null;
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
