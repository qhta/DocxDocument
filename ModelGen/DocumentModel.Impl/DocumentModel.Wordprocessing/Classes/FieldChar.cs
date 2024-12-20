namespace DocumentModel.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public partial class FieldCharImpl: ModelElementImpl, FieldChar
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.FieldChar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FieldChar?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FieldCharImpl(): base() {}
  
  public FieldCharImpl(DocumentFormat.OpenXml.Wordprocessing.FieldChar openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Field Character Type
  /// </summary>
  public DocumentModel.Wordprocessing.FieldCharKind? FieldCharType
  {
    get => (DocumentModel.Wordprocessing.FieldCharKind?)OpenXmlElement?.FieldCharType?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.FieldLock?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Dirty?.Value;
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
    get => (System.String?)OpenXmlElement?.FieldData?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FieldData != null)
        {
          if (value is not null)
            OpenXmlElement.FieldData.Text = value;
          else
            OpenXmlElement.FieldData = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FieldData = new DocumentFormat.OpenXml.Wordprocessing.FieldData{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.FormFieldData? FormFieldData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldData>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FormFieldDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FormFieldDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingChange? NumberingChange
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
        if (item != null)
          return new DocumentModel.Wordprocessing.NumberingChangeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.NumberingChangeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
