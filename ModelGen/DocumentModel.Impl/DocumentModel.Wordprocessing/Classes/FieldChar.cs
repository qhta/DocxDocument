namespace DocumentModel.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public class FieldCharImpl: ModelElementImpl, FieldChar
{
  public DocumentFormat.OpenXml.Wordprocessing.FieldChar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FieldChar?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Field Character Type
  /// </summary>
  public FieldCharKind? FieldCharType
  {
    get => (FieldCharKind?)OpenXmlElement?.FieldCharType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FieldCharType = (DocumentFormat.OpenXml.Wordprocessing.FieldCharValues?)value;
    }
  }
  
  /// <summary>
  /// Field Should Not Be Recalculated
  /// </summary>
  public Boolean? FieldLock
  {
    get => (Boolean?)OpenXmlElement?.FieldLock?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FieldLock = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Field Result Invalidated
  /// </summary>
  public Boolean? Dirty
  {
    get => (Boolean?)OpenXmlElement?.Dirty?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dirty = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Custom Field Data.
  /// </summary>
  public String? FieldData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldData>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldData>();
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
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.FieldData{ Text = value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public FormFieldData? FormFieldData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public NumberingChange? NumberingChange
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
