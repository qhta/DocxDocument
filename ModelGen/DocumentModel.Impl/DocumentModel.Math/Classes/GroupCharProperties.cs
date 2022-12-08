namespace DocumentModel.Math;

/// <summary>
/// Group-Character Properties.
/// </summary>
public class GroupCharPropertiesImpl: ModelElementImpl, GroupCharProperties
{
  public DocumentFormat.OpenXml.Math.GroupCharProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.GroupCharProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Group Character (Grouping Character).
  /// </summary>
  public String? AccentChar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Position (Group Character).
  /// </summary>
  public VerticalJustificationKind? Position
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Position>();
        return (VerticalJustificationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Position>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.Position{ Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  public VerticalJustificationKind? VerticalJustification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.VerticalJustification>();
        return (VerticalJustificationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.VerticalJustification>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.VerticalJustification{ Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
