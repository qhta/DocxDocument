namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public class TextOutlineEffectImpl: ModelElementImpl, TextOutlineEffect
{
  public DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? LineWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  public LineCapKind? CapType
  {
    get => (LineCapKind?)OpenXmlElement?.CapType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CapType = (DocumentFormat.OpenXml.Office2010.Word.LineCapValues?)value;
    }
  }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public CompoundLineKind? Compound
  {
    get => (CompoundLineKind?)OpenXmlElement?.Compound?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Compound = (DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues?)value;
    }
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public PenAlignmentKind? Alignment
  {
    get => (PenAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues?)value;
    }
  }
  
  public Boolean? NoFillEmpty
  {
    get;
    set;
  }
  
  public SolidColorFillProperties? SolidColorFillProperties
  {
    get;
    set;
  }
  
  public GradientFillProperties? GradientFillProperties
  {
    get;
    set;
  }
  
  public PresetLineDashKind? PresetLineDashProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties>();
        return (PresetLineDashKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties{ Val = (DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Boolean? RoundEmpty
  {
    get;
    set;
  }
  
  public Boolean? BevelEmpty
  {
    get;
    set;
  }
  
  public LineJoinMiterProperties? LineJoinMiterProperties
  {
    get;
    set;
  }
  
}
