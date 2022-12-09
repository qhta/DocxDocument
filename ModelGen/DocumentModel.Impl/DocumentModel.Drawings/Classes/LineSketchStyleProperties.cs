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
  
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? Sd
  {
    get => (UInt32?)OpenXmlElement?.Sd?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Sd = (System.UInt32?)value;
    }
  }
  
  public CustomGeometry? CustomGeometry
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PresetGeometry? PresetGeometry
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LineSketchTypeProperties? LineSketchTypeProperties
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Text = value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed{ Text = value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public OfficeArtExtensionList8? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
