namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public class KeyMapEntryImpl: ModelElementImpl, KeyMapEntry
{
  public DocumentFormat.OpenXml.Office.Word.KeyMapEntry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.KeyMapEntry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public KeyMapEntryImpl(): base() {}
  
  public KeyMapEntryImpl(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// chmPrimary
  /// </summary>
  public DocumentModel.HexBinary? CharacterMapPrimary
  {
    get
    {
      if (OpenXmlElement?.CharacterMapPrimary?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.CharacterMapPrimary.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.CharacterMapPrimary = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.CharacterMapPrimary = null;
      }
    }
  }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  public DocumentModel.HexBinary? CharacterMapSecondary
  {
    get
    {
      if (OpenXmlElement?.CharacterMapSecondary?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.CharacterMapSecondary.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.CharacterMapSecondary = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.CharacterMapSecondary = null;
      }
    }
  }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  public DocumentModel.HexBinary? KeyCodePrimary
  {
    get
    {
      if (OpenXmlElement?.KeyCodePrimary?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.KeyCodePrimary.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.KeyCodePrimary = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.KeyCodePrimary = null;
      }
    }
  }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  public DocumentModel.HexBinary? KeyCodeSecondary
  {
    get
    {
      if (OpenXmlElement?.KeyCodeSecondary?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.KeyCodeSecondary.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.KeyCodeSecondary = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.KeyCodeSecondary = null;
      }
    }
  }
  
  /// <summary>
  /// mask
  /// </summary>
  public Boolean? Mask
  {
    get => (System.Boolean?)OpenXmlElement?.Mask?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Mask = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FixedCommandKeyboardCustomizationImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FixedCommandKeyboardCustomizationImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public DocumentModel.Wordprocessing.MacroWllType? MacroKeyboardCustomization
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.MacroWllType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.MacroWllTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.MacroWllType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.MacroWllTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public DocumentModel.Wordprocessing.AcceleratorKeymapType? AllocatedCommandKeyboardCustomization
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.AcceleratorKeymapTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.AcceleratorKeymapType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.AcceleratorKeymapTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  public DocumentModel.Wordprocessing.MacroWllType? WllMacroKeyboardCustomization
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.MacroWllType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.MacroWllTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.MacroWllType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.MacroWllTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  public DocumentModel.HexBinary? CharacterInsertion
  {
    get
    {
      if (OpenXmlElement?.CharacterInsertion?.Val?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.CharacterInsertion.Val.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.CharacterInsertion = new DocumentFormat.OpenXml.Office.Word.CharacterInsertion{ Val = value.ToString() };
        else
          OpenXmlElement.CharacterInsertion = null;
      }
    }
  }
  
}
