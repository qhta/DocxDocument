namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TextType Class.
/// </summary>
public static class TextTypeConverter
{

  #region TextType conversion
  private static string GetText(DXW.TextType openXmlElement)
  {
    return openXmlElement.Text;
  }

  private static bool CmpText(DXW.TextType openXmlElement, string value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.Text.Equals(value)) return true;
    diffs?.Add(objName, "Text", openXmlElement.Text, value);
    return false;
  }

  private static void SetText(DXW.TextType openXmlElement, string value)
  {
    openXmlElement.Text = value;
  }
  #endregion

  #region TextualElement conversion
  private static ElementType CreateModelElement<ElementType>(DXW.TextType openXmlElement)
    where ElementType : DMW.TextualElement, new()
  {
    var value = new ElementType();
    value.Text = GetText(openXmlElement);
    return value;
  }
  public static bool CompareModelElement(DXW.TextType? openXmlElement, DMW.TextualElement? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpText(openXmlElement, value.Text, diffs, objName))
        ok = false;
      bool isDeleted;
      if ((isDeleted = openXmlElement.GetType().Name.StartsWith("Deleted")) != value.IsDeleted)
      {
        diffs?.Add(objName, "Deleted", isDeleted, value.IsDeleted);
        ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TextualElement value)
    where OpenXmlElementType : DXW.TextType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.TextType openXmlElement, DMW.TextualElement value)
  {
    SetText(openXmlElement, value.Text);
    return true;
  }
  #endregion

  #region Text and DeletedText conversion
  public static DMW.Text CreateModelElement(DXW.Text openXmlElement)
    => CreateModelElement<DMW.Text>(openXmlElement);

  public static DMW.Text CreateModelElement(DXW.DeletedText openXmlElement)
  {
    var result = CreateModelElement<DMW.Text>(openXmlElement);
    result.IsDeleted = true;
    return result;
  }

  public static DXW.TextType CreateOpenXmlElement(DMW.Text value)
  {
    if (value.IsDeleted)
      return CreateOpenXmlElement<DXW.Text>(value);
    else
      return CreateOpenXmlElement<DXW.DeletedText>(value);
  }
  #endregion

  #region FieldCode and DeletedFieldCode conversion
  public static DMW.FieldCode CreateModelElement(DXW.FieldCode openXmlElement)
    => CreateModelElement<DMW.FieldCode>(openXmlElement);

  public static DMW.FieldCode CreateModelElement(DXW.DeletedFieldCode openXmlElement)
  {
    var result = CreateModelElement<DMW.FieldCode>(openXmlElement);
    result.IsDeleted = true;
    return result;
  }
  public static DXW.TextType CreateOpenXmlElement(DMW.FieldCode value)
  {
    if (value.IsDeleted)
      return CreateOpenXmlElement<DXW.FieldCode>(value);
    else
      return CreateOpenXmlElement<DXW.DeletedFieldCode>(value);
  }
  #endregion

  #region Math Text conversion
  public static DMM.Text CreateModelElement(DXM.Text openXmlElement)
  {
    var value = new DMM.Text();
    value.Text = openXmlElement.Text;
    return value;
  }

  private static bool CmpText(DXM.Text openXmlElement, string value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.Text.Equals(value)) return true;
    diffs?.Add(objName, "Text", openXmlElement.Text, value);
    return false;
  }

  public static bool CompareModelElement(DXM.Text? openXmlElement, DMM.Text? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpText(openXmlElement, value.Text, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  public static DXM.Text CreateOpenXmlElement(DMM.Text value)
  {
    var openXmlElement = new DXM.Text();
    openXmlElement.Text = value.Text;
    return openXmlElement;
  }
  #endregion
}
