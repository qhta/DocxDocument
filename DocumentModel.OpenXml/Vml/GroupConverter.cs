namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public static String? GetStyle(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public static String? GetHref(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  public static void SetHref(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Href = new StringValue { Value = value };
      else
        openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Hyperlink Display Target
  /// </summary>
  public static String? GetTarget(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }
  
  public static void SetTarget(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Target = new StringValue { Value = value };
      else
        openXmlElement.Target = null;
  }
  
  /// <summary>
  /// CSS Reference
  /// </summary>
  public static String? GetClass(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Class?.Value;
  }
  
  public static void SetClass(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Class = new StringValue { Value = value };
      else
        openXmlElement.Class = null;
  }
  
  /// <summary>
  /// Shape Title
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Alternate Text
  /// </summary>
  public static String? GetAlternate(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.Alternate?.Value;
  }
  
  public static void SetAlternate(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Alternate = new StringValue { Value = value };
      else
        openXmlElement.Alternate = null;
  }
  
  /// <summary>
  /// Coordinate Space Size
  /// </summary>
  public static String? GetCoordinateSize(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.CoordinateSize?.Value;
  }
  
  public static void SetCoordinateSize(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CoordinateSize = new StringValue { Value = value };
      else
        openXmlElement.CoordinateSize = null;
  }
  
  /// <summary>
  /// Coordinate Space Origin
  /// </summary>
  public static String? GetCoordinateOrigin(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.CoordinateOrigin?.Value;
  }
  
  public static void SetCoordinateOrigin(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CoordinateOrigin = new StringValue { Value = value };
      else
        openXmlElement.CoordinateOrigin = null;
  }
  
  /// <summary>
  /// Shape Bounding Polygon
  /// </summary>
  public static String? GetWrapCoordinates(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.WrapCoordinates?.Value;
  }
  
  public static void SetWrapCoordinates(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.WrapCoordinates = new StringValue { Value = value };
      else
        openXmlElement.WrapCoordinates = null;
  }
  
  /// <summary>
  /// Print Toggle
  /// </summary>
  public static Boolean? GetPrint(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetPrint(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// spid
  /// </summary>
  public static String? GetOptionalString(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.OptionalString?.Value;
  }
  
  public static void SetOptionalString(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OptionalString = new StringValue { Value = value };
      else
        openXmlElement.OptionalString = null;
  }
  
  /// <summary>
  /// oned
  /// </summary>
  public static Boolean? GetOned(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetOned(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// regroupid
  /// </summary>
  public static Int64? GetRegroupId(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.RegroupId?.Value;
  }
  
  public static void SetRegroupId(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.RegroupId = value;
  }
  
  /// <summary>
  /// doubleclicknotify
  /// </summary>
  public static Boolean? GetDoubleClickNotify(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetDoubleClickNotify(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// button
  /// </summary>
  public static Boolean? GetButton(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetButton(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// userhidden
  /// </summary>
  public static Boolean? GetUserHidden(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetUserHidden(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// bullet
  /// </summary>
  public static Boolean? GetBullet(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetBullet(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// hr
  /// </summary>
  public static Boolean? GetHorizontal(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetHorizontal(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// hrstd
  /// </summary>
  public static Boolean? GetHorizontalStandard(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetHorizontalStandard(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// hrnoshade
  /// </summary>
  public static Boolean? GetHorizontalNoShade(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetHorizontalNoShade(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// hrpct
  /// </summary>
  public static Single? GetHorizontalPercentage(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.HorizontalPercentage?.Value;
  }
  
  public static void SetHorizontalPercentage(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Single? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalPercentage = value;
  }
  
  /// <summary>
  /// hralign
  /// </summary>
  public static DocumentModel.Vml.HorizontalRuleAlignmentKind? GetHorizontalAlignment(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DocumentModel.Vml.HorizontalRuleAlignmentKind>(openXmlElement?.HorizontalAlignment?.Value);
  }
  
  public static void SetHorizontalAlignment(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.HorizontalRuleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues, DocumentModel.Vml.HorizontalRuleAlignmentKind>(value);
  }
  
  /// <summary>
  /// allowincell
  /// </summary>
  public static Boolean? GetAllowInCell(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowInCell(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public static Boolean? GetAllowOverlap(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetAllowOverlap(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// userdrawn
  /// </summary>
  public static Boolean? GetUserDrawn(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetUserDrawn(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// dgmlayout
  /// </summary>
  public static Int64? GetDiagramLayout(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.DiagramLayout?.Value;
  }
  
  public static void SetDiagramLayout(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayout = value;
  }
  
  /// <summary>
  /// dgmnodekind
  /// </summary>
  public static Int64? GetDiagramNodeKind(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.DiagramNodeKind?.Value;
  }
  
  public static void SetDiagramNodeKind(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramNodeKind = value;
  }
  
  /// <summary>
  /// dgmlayoutmru
  /// </summary>
  public static Int64? GetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.DiagramLayoutMostRecentUsed?.Value;
  }
  
  public static void SetDiagramLayoutMostRecentUsed(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DiagramLayoutMostRecentUsed = value;
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public static DocumentModel.Vml.InsetMarginKind? GetInsetMode(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(openXmlElement?.InsetMode?.Value);
  }
  
  public static void SetInsetMode(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.InsetMarginKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.InsetMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues, DocumentModel.Vml.InsetMarginKind>(value);
  }
  
  /// <summary>
  /// Encoded Package
  /// </summary>
  public static DocumentModel.Base64Binary? GetGfxdata(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  public static void SetGfxdata(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Base64Binary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Base64BinaryValue");
  }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  public static DocumentModel.Vml.EditAsKind? GetEditAs(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.EditAsValues, DocumentModel.Vml.EditAsKind>(openXmlElement?.EditAs?.Value);
  }
  
  public static void SetEditAs(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.EditAsKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EditAs = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.EditAsValues, DocumentModel.Vml.EditAsKind>(value);
  }
  
  /// <summary>
  /// Table Properties
  /// </summary>
  public static String? GetTableProperties(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.TableProperties?.Value;
  }
  
  public static void SetTableProperties(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TableProperties = new StringValue { Value = value };
      else
        openXmlElement.TableProperties = null;
  }
  
  /// <summary>
  /// Table Row Height Limits
  /// </summary>
  public static String? GetTableLimits(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    return openXmlElement?.TableLimits?.Value;
  }
  
  public static void SetTableLimits(DocumentFormat.OpenXml.Vml.Group? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TableLimits = new StringValue { Value = value };
      else
        openXmlElement.TableLimits = null;
  }
  
  public static DocumentModel.Vml.Group? GetChildGroup(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.GroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChildGroup(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Group? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.GroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Group>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Shape? GetShape(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Shape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Shapetype? GetShapetype(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapetype(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Shapetype? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ShapetypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shapetype>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Arc? GetArc(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ArcConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArc(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Arc? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ArcConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Arc>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Curve? GetCurve(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.CurveConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCurve(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Curve? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.CurveConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Curve>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.ImageFile? GetImageFile(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetImageFile(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.ImageFile? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ImageFileConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ImageFile>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Line? GetLine(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLine(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Line? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.LineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Line>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Oval? GetOval(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.OvalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOval(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Oval? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.OvalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Oval>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.PolyLine? GetPolyLine(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPolyLine(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.PolyLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.PolyLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.PolyLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Rectangle? GetRectangle(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRectangle(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Rectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.RectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Rectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.RoundRectangle? GetRoundRectangle(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRoundRectangle(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.RoundRectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.RoundRectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.RoundRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Diagram? GetDiagram(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.DiagramConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDiagram(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Diagram? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.DiagramConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Diagram>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Lock? GetLock(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLock(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.Lock? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.LockConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Lock>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.ClipPath? GetClipPath(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ClipPathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetClipPath(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Vml.ClipPath? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ClipPathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ClipPath>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Vml.TextWrap? GetTextWrap(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Vml.TextWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextWrap(DocumentFormat.OpenXml.Vml.Group? openXmlElement, DocumentModel.Wordprocessing.Vml.TextWrap? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.Vml.TextWrapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetAnchorLock(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAnchorLock(DocumentFormat.OpenXml.Vml.Group? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Group? CreateModelElement(DocumentFormat.OpenXml.Vml.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Group();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.Href = GetHref(openXmlElement);
      value.Target = GetTarget(openXmlElement);
      value.Class = GetClass(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.Alternate = GetAlternate(openXmlElement);
      value.CoordinateSize = GetCoordinateSize(openXmlElement);
      value.CoordinateOrigin = GetCoordinateOrigin(openXmlElement);
      value.WrapCoordinates = GetWrapCoordinates(openXmlElement);
      value.Print = GetPrint(openXmlElement);
      value.OptionalString = GetOptionalString(openXmlElement);
      value.Oned = GetOned(openXmlElement);
      value.RegroupId = GetRegroupId(openXmlElement);
      value.DoubleClickNotify = GetDoubleClickNotify(openXmlElement);
      value.Button = GetButton(openXmlElement);
      value.UserHidden = GetUserHidden(openXmlElement);
      value.Bullet = GetBullet(openXmlElement);
      value.Horizontal = GetHorizontal(openXmlElement);
      value.HorizontalStandard = GetHorizontalStandard(openXmlElement);
      value.HorizontalNoShade = GetHorizontalNoShade(openXmlElement);
      value.HorizontalPercentage = GetHorizontalPercentage(openXmlElement);
      value.HorizontalAlignment = GetHorizontalAlignment(openXmlElement);
      value.AllowInCell = GetAllowInCell(openXmlElement);
      value.AllowOverlap = GetAllowOverlap(openXmlElement);
      value.UserDrawn = GetUserDrawn(openXmlElement);
      value.DiagramLayout = GetDiagramLayout(openXmlElement);
      value.DiagramNodeKind = GetDiagramNodeKind(openXmlElement);
      value.DiagramLayoutMostRecentUsed = GetDiagramLayoutMostRecentUsed(openXmlElement);
      value.InsetMode = GetInsetMode(openXmlElement);
      value.Gfxdata = GetGfxdata(openXmlElement);
      value.EditAs = GetEditAs(openXmlElement);
      value.TableProperties = GetTableProperties(openXmlElement);
      value.TableLimits = GetTableLimits(openXmlElement);
      value.ChildGroup = GetChildGroup(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.Shapetype = GetShapetype(openXmlElement);
      value.Arc = GetArc(openXmlElement);
      value.Curve = GetCurve(openXmlElement);
      value.ImageFile = GetImageFile(openXmlElement);
      value.Line = GetLine(openXmlElement);
      value.Oval = GetOval(openXmlElement);
      value.PolyLine = GetPolyLine(openXmlElement);
      value.Rectangle = GetRectangle(openXmlElement);
      value.RoundRectangle = GetRoundRectangle(openXmlElement);
      value.Diagram = GetDiagram(openXmlElement);
      value.Lock = GetLock(openXmlElement);
      value.ClipPath = GetClipPath(openXmlElement);
      value.TextWrap = GetTextWrap(openXmlElement);
      value.AnchorLock = GetAnchorLock(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Group? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Group, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
