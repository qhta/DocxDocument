namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// If.
/// </summary>
public static class DiagramChooseIfConverter
{
  /// <summary>
  /// Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public static DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? GetAxis(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.EnumValue`1[DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues]] type");
  }
  
  public static void SetAxis(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.EnumValue`1[DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues]] type");
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public static DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? GetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.EnumValue`1[DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues]] type");
  }
  
  public static void SetPointType(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.EnumValue`1[DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues]] type");
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public static DocumentModel.ListOf<Boolean>? GetHideLastTrans(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.BooleanValue] type");
  }
  
  public static void SetHideLastTrans(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<Boolean>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.BooleanValue] type");
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public static DocumentModel.ListOf<Int32>? GetStart(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.Int32Value] type");
  }
  
  public static void SetStart(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<Int32>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.Int32Value] type");
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public static DocumentModel.ListOf<UInt32>? GetCount(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.UInt32Value] type");
  }
  
  public static void SetCount(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.UInt32Value] type");
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public static DocumentModel.ListOf<Int32>? GetStep(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.Int32Value] type");
  }
  
  public static void SetStep(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.ListOf<Int32>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.Int32Value] type");
  }
  
  /// <summary>
  /// Function
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.FunctionKind? GetFunction(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DocumentModel.Drawings.Diagrams.FunctionKind>(openXmlElement?.Function?.Value);
  }
  
  public static void SetFunction(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.FunctionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Function = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DocumentModel.Drawings.Diagrams.FunctionKind>(value);
  }
  
  /// <summary>
  /// Argument
  /// </summary>
  public static String? GetArgument(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    return openXmlElement?.Argument?.Value;
  }
  
  public static void SetArgument(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Argument = new StringValue { Value = value };
      else
        openXmlElement.Argument = null;
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.FunctionOperatorKind? GetOperator(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DocumentModel.Drawings.Diagrams.FunctionOperatorKind>(openXmlElement?.Operator?.Value);
  }
  
  public static void SetOperator(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.FunctionOperatorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Operator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DocumentModel.Drawings.Diagrams.FunctionOperatorKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  public static DocumentModel.Drawings.Diagrams.Algorithm? GetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.AlgorithmConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.Algorithm? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.AlgorithmConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Shape? GetShape(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.Shape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.PresentationOf? GetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.PresentationOfConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.PresentationOf? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.PresentationOfConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Constraints? GetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ConstraintsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.Constraints? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ConstraintsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.RuleList? GetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.RuleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.RuleList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.RuleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ForEach? GetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ForEachConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.ForEach? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ForEachConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutNode? GetLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.LayoutNode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.LayoutNodeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Choose? GetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ChooseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.Choose? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ChooseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DiagramChooseIf? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DiagramChooseIf();
      value.Name = GetName(openXmlElement);
      value.Axis = GetAxis(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.HideLastTrans = GetHideLastTrans(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Count = GetCount(openXmlElement);
      value.Step = GetStep(openXmlElement);
      value.Function = GetFunction(openXmlElement);
      value.Argument = GetArgument(openXmlElement);
      value.Operator = GetOperator(openXmlElement);
      value.Val = GetVal(openXmlElement);
      value.Algorithm = GetAlgorithm(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.PresentationOf = GetPresentationOf(openXmlElement);
      value.Constraints = GetConstraints(openXmlElement);
      value.RuleList = GetRuleList(openXmlElement);
      value.ForEach = GetForEach(openXmlElement);
      value.LayoutNode = GetLayoutNode(openXmlElement);
      value.Choose = GetChoose(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DiagramChooseIf? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetAxis(openXmlElement, value?.Axis);
      SetPointType(openXmlElement, value?.PointType);
      SetHideLastTrans(openXmlElement, value?.HideLastTrans);
      SetStart(openXmlElement, value?.Start);
      SetCount(openXmlElement, value?.Count);
      SetStep(openXmlElement, value?.Step);
      SetFunction(openXmlElement, value?.Function);
      SetArgument(openXmlElement, value?.Argument);
      SetOperator(openXmlElement, value?.Operator);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
