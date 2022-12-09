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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CustomDisplayUnit>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Double?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.CustomDisplayUnit{ Val = (System.Double?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit{ Val = (DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
  
  public ExtensionList3? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
