namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public class LineSketchStylePropertiesImpl: ModelElementImpl, LineSketchStyleProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineSketchStylePropertiesImpl(): base() {}
  
  public LineSketchStylePropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? Sd
  {
    get => (System.UInt32?)OpenXmlElement?.Sd?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Sd = (System.UInt32?)value;
    }
  }
  
  public DocumentModel.Drawings.CustomGeometry? CustomGeometry
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.PresetGeometry? PresetGeometry
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.LineSketchTypeProperties? LineSketchTypeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public String? LineSketchSeed
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed>();
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
            item = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
