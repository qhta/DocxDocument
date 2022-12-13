namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the LegendStyle Class.
/// </summary>
public class LegendStyleImpl: DocumentModel.Drawings13.Charts.StyleEntryImpl, LegendStyle
{
  public new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LegendStyleImpl(): base() {}
  
  public LegendStyleImpl(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings13.Charts.LineReference? LineReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? LineWidthScale
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public new DocumentModel.Drawings13.Charts.FillReference? FillReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings13.Charts.EffectReference? EffectReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings13.Charts.FontReference? FontReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings13.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings13.Charts.TextCharacterPropertiesType? TextCharacterPropertiesType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings13.Charts.TextBodyProperties? TextBodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings13.Charts.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
