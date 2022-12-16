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
  
  public GroupCharPropertiesImpl(): base() {}
  
  public GroupCharPropertiesImpl(DocumentFormat.OpenXml.Math.GroupCharProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Group Character (Grouping Character).
  /// </summary>
  public String? AccentChar
  {
    get => (System.String?)OpenXmlElement?.AccentChar?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AccentChar != null)
        {
          if (value is not null)
            OpenXmlElement.AccentChar.Val = (System.String?)value;
          else
            OpenXmlElement.AccentChar = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AccentChar = new DocumentFormat.OpenXml.Math.AccentChar{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Position (Group Character).
  /// </summary>
  public DocumentModel.Math.VerticalJustificationKind? Position
  {
    get => (DocumentModel.Math.VerticalJustificationKind?)OpenXmlElement?.Position?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Position != null)
        {
          if (value is not null)
            OpenXmlElement.Position.Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value;
          else
            OpenXmlElement.Position = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Position = new DocumentFormat.OpenXml.Math.Position{ Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  public DocumentModel.Math.VerticalJustificationKind? VerticalJustification
  {
    get => (DocumentModel.Math.VerticalJustificationKind?)OpenXmlElement?.VerticalJustification?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.VerticalJustification != null)
        {
          if (value is not null)
            OpenXmlElement.VerticalJustification.Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value;
          else
            OpenXmlElement.VerticalJustification = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.VerticalJustification = new DocumentFormat.OpenXml.Math.VerticalJustification{ Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          return new DocumentModel.Math.ControlPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.ControlPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
