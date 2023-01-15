using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentModel.Drawings;
using Boolean = System.Boolean;
using FlatText = DocumentModel.Drawings.FlatText;
using NormalAutoFit = DocumentModel.Drawings.NormalAutoFit;
using PresetTextWrap = DocumentModel.Drawings.PresetTextWrap;
using Scene3DType = DocumentModel.Drawings.Scene3DType;
using Shape3DType = DocumentModel.Drawings.Shape3DType;

namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
///   Defines the TextBodyProperties Class.
/// </summary>
public static class TextBodyPropertiesConverter
{
  /// <summary>
  ///   Rotation
  /// </summary>
  public static Int32? GetRotation(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }

  public static void SetRotation(TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rotation = value;
  }

  /// <summary>
  ///   Paragraph Spacing
  /// </summary>
  public static Boolean? GetUseParagraphSpacing(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.UseParagraphSpacing?.Value;
  }

  public static void SetUseParagraphSpacing(TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseParagraphSpacing = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UseParagraphSpacing = null;
  }

  /// <summary>
  ///   Text Vertical Overflow
  /// </summary>
  public static TextVerticalOverflowKind? GetVerticalOverflow(TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextVerticalOverflowValues, TextVerticalOverflowKind>(openXmlElement?.VerticalOverflow?.Value);
  }

  public static void SetVerticalOverflow(TextBodyProperties? openXmlElement, TextVerticalOverflowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalOverflow = EnumValueConverter.CreateEnumValue<TextVerticalOverflowValues, TextVerticalOverflowKind>(value);
  }

  /// <summary>
  ///   Text Horizontal Overflow
  /// </summary>
  public static TextHorizontalOverflowKind? GetHorizontalOverflow(TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextHorizontalOverflowValues, TextHorizontalOverflowKind>(openXmlElement?.HorizontalOverflow?.Value);
  }

  public static void SetHorizontalOverflow(TextBodyProperties? openXmlElement, TextHorizontalOverflowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalOverflow = EnumValueConverter.CreateEnumValue<TextHorizontalOverflowValues, TextHorizontalOverflowKind>(value);
  }

  /// <summary>
  ///   Vertical Text
  /// </summary>
  public static TextVerticalKind? GetVertical(TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextVerticalValues, TextVerticalKind>(openXmlElement?.Vertical?.Value);
  }

  public static void SetVertical(TextBodyProperties? openXmlElement, TextVerticalKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Vertical = EnumValueConverter.CreateEnumValue<TextVerticalValues, TextVerticalKind>(value);
  }

  /// <summary>
  ///   Text Wrapping Type
  /// </summary>
  public static TextWrappingKind? GetWrap(TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextWrappingValues, TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }

  public static void SetWrap(TextBodyProperties? openXmlElement, TextWrappingKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<TextWrappingValues, TextWrappingKind>(value);
  }

  /// <summary>
  ///   Left Inset
  /// </summary>
  public static Int32? GetLeftInset(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.LeftInset?.Value;
  }

  public static void SetLeftInset(TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LeftInset = value;
  }

  /// <summary>
  ///   Top Inset
  /// </summary>
  public static Int32? GetTopInset(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.TopInset?.Value;
  }

  public static void SetTopInset(TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.TopInset = value;
  }

  /// <summary>
  ///   Right Inset
  /// </summary>
  public static Int32? GetRightInset(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.RightInset?.Value;
  }

  public static void SetRightInset(TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RightInset = value;
  }

  /// <summary>
  ///   Bottom Inset
  /// </summary>
  public static Int32? GetBottomInset(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.BottomInset?.Value;
  }

  public static void SetBottomInset(TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.BottomInset = value;
  }

  /// <summary>
  ///   Number of Columns
  /// </summary>
  public static Int32? GetColumnCount(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.ColumnCount?.Value;
  }

  public static void SetColumnCount(TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnCount = value;
  }

  /// <summary>
  ///   Space Between Columns
  /// </summary>
  public static Int32? GetColumnSpacing(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.ColumnSpacing?.Value;
  }

  public static void SetColumnSpacing(TextBodyProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnSpacing = value;
  }

  /// <summary>
  ///   Columns Right-To-Left
  /// </summary>
  public static Boolean? GetRightToLeftColumns(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.RightToLeftColumns?.Value;
  }

  public static void SetRightToLeftColumns(TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RightToLeftColumns = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RightToLeftColumns = null;
  }

  /// <summary>
  ///   From WordArt
  /// </summary>
  public static Boolean? GetFromWordArt(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.FromWordArt?.Value;
  }

  public static void SetFromWordArt(TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FromWordArt = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.FromWordArt = null;
  }

  /// <summary>
  ///   Anchor
  /// </summary>
  public static TextAnchoringKind? GetAnchor(TextBodyProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextAnchoringTypeValues, TextAnchoringKind>(openXmlElement?.Anchor?.Value);
  }

  public static void SetAnchor(TextBodyProperties? openXmlElement, TextAnchoringKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Anchor = EnumValueConverter.CreateEnumValue<TextAnchoringTypeValues, TextAnchoringKind>(value);
  }

  /// <summary>
  ///   Anchor Center
  /// </summary>
  public static Boolean? GetAnchorCenter(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.AnchorCenter?.Value;
  }

  public static void SetAnchorCenter(TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AnchorCenter = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.AnchorCenter = null;
  }

  /// <summary>
  ///   Force Anti-Alias
  /// </summary>
  public static Boolean? GetForceAntiAlias(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.ForceAntiAlias?.Value;
  }

  public static void SetForceAntiAlias(TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForceAntiAlias = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ForceAntiAlias = null;
  }

  /// <summary>
  ///   Text Upright
  /// </summary>
  public static Boolean? GetUpRight(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.UpRight?.Value;
  }

  public static void SetUpRight(TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UpRight = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.UpRight = null;
  }

  /// <summary>
  ///   Compatible Line Spacing
  /// </summary>
  public static Boolean? GetCompatibleLineSpacing(TextBodyProperties? openXmlElement)
  {
    return openXmlElement?.CompatibleLineSpacing?.Value;
  }

  public static void SetCompatibleLineSpacing(TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CompatibleLineSpacing = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.CompatibleLineSpacing = null;
  }

  /// <summary>
  ///   Preset Text Shape.
  /// </summary>
  public static PresetTextWrap? GetPresetTextWrap(TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
    if (itemElement != null)
      return PresetTextWrapConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresetTextWrap(TextBodyProperties? openXmlElement, PresetTextWrap? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetTextWrapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetTextWrap>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetNoAutoFit(TextBodyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoAutoFit>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoAutoFit(TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoAutoFit>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoAutoFit();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static NormalAutoFit? GetNormalAutoFit(TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
    if (itemElement != null)
      return NormalAutoFitConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNormalAutoFit(TextBodyProperties? openXmlElement, NormalAutoFit? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NormalAutoFitConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NormalAutoFit>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShapeAutoFit(TextBodyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShapeAutoFit>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShapeAutoFit(TextBodyProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShapeAutoFit>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShapeAutoFit();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Scene3DType? GetScene3DType(TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
    if (itemElement != null)
      return Scene3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScene3DType(TextBodyProperties? openXmlElement, Scene3DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Scene3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Scene3DType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Shape3DType? GetShape3DType(TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
    if (itemElement != null)
      return Shape3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape3DType(TextBodyProperties? openXmlElement, Shape3DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Shape3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Shape3DType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FlatText? GetFlatText(TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
    if (itemElement != null)
      return FlatTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFlatText(TextBodyProperties? openXmlElement, FlatText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FlatTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FlatText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(TextBodyProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(TextBodyProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartsStyle.TextBodyProperties? CreateModelElement(TextBodyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.TextBodyProperties();
      value.Rotation = GetRotation(openXmlElement);
      value.UseParagraphSpacing = GetUseParagraphSpacing(openXmlElement);
      value.VerticalOverflow = GetVerticalOverflow(openXmlElement);
      value.HorizontalOverflow = GetHorizontalOverflow(openXmlElement);
      value.Vertical = GetVertical(openXmlElement);
      value.Wrap = GetWrap(openXmlElement);
      value.LeftInset = GetLeftInset(openXmlElement);
      value.TopInset = GetTopInset(openXmlElement);
      value.RightInset = GetRightInset(openXmlElement);
      value.BottomInset = GetBottomInset(openXmlElement);
      value.ColumnCount = GetColumnCount(openXmlElement);
      value.ColumnSpacing = GetColumnSpacing(openXmlElement);
      value.RightToLeftColumns = GetRightToLeftColumns(openXmlElement);
      value.FromWordArt = GetFromWordArt(openXmlElement);
      value.Anchor = GetAnchor(openXmlElement);
      value.AnchorCenter = GetAnchorCenter(openXmlElement);
      value.ForceAntiAlias = GetForceAntiAlias(openXmlElement);
      value.UpRight = GetUpRight(openXmlElement);
      value.CompatibleLineSpacing = GetCompatibleLineSpacing(openXmlElement);
      value.PresetTextWrap = GetPresetTextWrap(openXmlElement);
      value.NoAutoFit = GetNoAutoFit(openXmlElement);
      value.NormalAutoFit = GetNormalAutoFit(openXmlElement);
      value.ShapeAutoFit = GetShapeAutoFit(openXmlElement);
      value.Scene3DType = GetScene3DType(openXmlElement);
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.FlatText = GetFlatText(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.TextBodyProperties? value)
    where OpenXmlElementType : TextBodyProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotation(openXmlElement, value?.Rotation);
      SetUseParagraphSpacing(openXmlElement, value?.UseParagraphSpacing);
      SetVerticalOverflow(openXmlElement, value?.VerticalOverflow);
      SetHorizontalOverflow(openXmlElement, value?.HorizontalOverflow);
      SetVertical(openXmlElement, value?.Vertical);
      SetWrap(openXmlElement, value?.Wrap);
      SetLeftInset(openXmlElement, value?.LeftInset);
      SetTopInset(openXmlElement, value?.TopInset);
      SetRightInset(openXmlElement, value?.RightInset);
      SetBottomInset(openXmlElement, value?.BottomInset);
      SetColumnCount(openXmlElement, value?.ColumnCount);
      SetColumnSpacing(openXmlElement, value?.ColumnSpacing);
      SetRightToLeftColumns(openXmlElement, value?.RightToLeftColumns);
      SetFromWordArt(openXmlElement, value?.FromWordArt);
      SetAnchor(openXmlElement, value?.Anchor);
      SetAnchorCenter(openXmlElement, value?.AnchorCenter);
      SetForceAntiAlias(openXmlElement, value?.ForceAntiAlias);
      SetUpRight(openXmlElement, value?.UpRight);
      SetCompatibleLineSpacing(openXmlElement, value?.CompatibleLineSpacing);
      SetPresetTextWrap(openXmlElement, value?.PresetTextWrap);
      SetNoAutoFit(openXmlElement, value?.NoAutoFit);
      SetNormalAutoFit(openXmlElement, value?.NormalAutoFit);
      SetShapeAutoFit(openXmlElement, value?.ShapeAutoFit);
      SetScene3DType(openXmlElement, value?.Scene3DType);
      SetShape3DType(openXmlElement, value?.Shape3DType);
      SetFlatText(openXmlElement, value?.FlatText);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}