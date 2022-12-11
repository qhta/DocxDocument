namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public class DisplayUnitsImpl: ModelElementImpl, DisplayUnits
{
  public DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DisplayUnitsImpl(): base() {}
  
  public DisplayUnitsImpl(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Double? CustomDisplayUnit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CustomDisplayUnit>();
        return (Double?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CustomDisplayUnit>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Double?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.CustomDisplayUnit{ Val = (System.Double?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public BuiltInUnitKind? BuiltInUnit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
        return (BuiltInUnitKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit{ Val = (DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DisplayUnitsLabel? DisplayUnitsLabel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
