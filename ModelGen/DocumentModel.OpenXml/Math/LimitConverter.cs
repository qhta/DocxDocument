namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Limit (Lower).
/// </summary>
public static class LimitConverter
{
  private static DMMath.ArgumentProperties? GetArgumentProperties(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ArgumentProperties>();
    if (element != null)
      return DMXMath.ArgumentPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgumentProperties(DXMath.Limit openXmlElement, DMMath.ArgumentProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ArgumentPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ArgumentProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetArgumentProperties(DXMath.Limit openXmlElement, DMMath.ArgumentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ArgumentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ArgumentPropertiesConverter.CreateOpenXmlElement<DXMath.ArgumentProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Accent? GetAccent(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Accent>();
    if (element != null)
      return DMXMath.AccentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAccent(DXMath.Limit openXmlElement, DMMath.Accent? value, DiffList? diffs, string? objName)
  {
    return DMXMath.AccentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Accent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAccent(DXMath.Limit openXmlElement, DMMath.Accent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Accent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.AccentConverter.CreateOpenXmlElement<DXMath.Accent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Bar? GetBar(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Bar>();
    if (element != null)
      return DMXMath.BarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBar(DXMath.Limit openXmlElement, DMMath.Bar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Bar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBar(DXMath.Limit openXmlElement, DMMath.Bar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Bar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BarConverter.CreateOpenXmlElement<DXMath.Bar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Box? GetBox(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Box>();
    if (element != null)
      return DMXMath.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBox(DXMath.Limit openXmlElement, DMMath.Box? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Box>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBox(DXMath.Limit openXmlElement, DMMath.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BoxConverter.CreateOpenXmlElement<DXMath.Box>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.BorderBox? GetBorderBox(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.BorderBox>();
    if (element != null)
      return DMXMath.BorderBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBorderBox(DXMath.Limit openXmlElement, DMMath.BorderBox? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BorderBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.BorderBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBorderBox(DXMath.Limit openXmlElement, DMMath.BorderBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BorderBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BorderBoxConverter.CreateOpenXmlElement<DXMath.BorderBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Delimiter? GetDelimiter(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Delimiter>();
    if (element != null)
      return DMXMath.DelimiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDelimiter(DXMath.Limit openXmlElement, DMMath.Delimiter? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DelimiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Delimiter>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDelimiter(DXMath.Limit openXmlElement, DMMath.Delimiter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Delimiter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DelimiterConverter.CreateOpenXmlElement<DXMath.Delimiter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.EquationArray? GetEquationArray(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.EquationArray>();
    if (element != null)
      return DMXMath.EquationArrayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEquationArray(DXMath.Limit openXmlElement, DMMath.EquationArray? value, DiffList? diffs, string? objName)
  {
    return DMXMath.EquationArrayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.EquationArray>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEquationArray(DXMath.Limit openXmlElement, DMMath.EquationArray? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.EquationArray>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.EquationArrayConverter.CreateOpenXmlElement<DXMath.EquationArray>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Fraction? GetFraction(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Fraction>();
    if (element != null)
      return DMXMath.FractionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFraction(DXMath.Limit openXmlElement, DMMath.Fraction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FractionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Fraction>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFraction(DXMath.Limit openXmlElement, DMMath.Fraction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Fraction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.FractionConverter.CreateOpenXmlElement<DXMath.Fraction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.MathFunction? GetMathFunction(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.MathFunction>();
    if (element != null)
      return DMXMath.MathFunctionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMathFunction(DXMath.Limit openXmlElement, DMMath.MathFunction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MathFunctionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.MathFunction>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMathFunction(DXMath.Limit openXmlElement, DMMath.MathFunction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MathFunction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MathFunctionConverter.CreateOpenXmlElement<DXMath.MathFunction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.GroupChar? GetGroupChar(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.GroupChar>();
    if (element != null)
      return DMXMath.GroupCharConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupChar(DXMath.Limit openXmlElement, DMMath.GroupChar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.GroupCharConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.GroupChar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroupChar(DXMath.Limit openXmlElement, DMMath.GroupChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.GroupChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.GroupCharConverter.CreateOpenXmlElement<DXMath.GroupChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitLower? GetLimitLower(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.LimitLower>();
    if (element != null)
      return DMXMath.LimitLowerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitLower(DXMath.Limit openXmlElement, DMMath.LimitLower? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitLowerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.LimitLower>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitLower(DXMath.Limit openXmlElement, DMMath.LimitLower? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitLower>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitLowerConverter.CreateOpenXmlElement<DXMath.LimitLower>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitUpper? GetLimitUpper(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.LimitUpper>();
    if (element != null)
      return DMXMath.LimitUpperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitUpper(DXMath.Limit openXmlElement, DMMath.LimitUpper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitUpperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.LimitUpper>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitUpper(DXMath.Limit openXmlElement, DMMath.LimitUpper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitUpper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitUpperConverter.CreateOpenXmlElement<DXMath.LimitUpper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Matrix? GetMatrix(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Matrix>();
    if (element != null)
      return DMXMath.MatrixConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMatrix(DXMath.Limit openXmlElement, DMMath.Matrix? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Matrix>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMatrix(DXMath.Limit openXmlElement, DMMath.Matrix? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Matrix>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MatrixConverter.CreateOpenXmlElement<DXMath.Matrix>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Nary? GetNary(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Nary>();
    if (element != null)
      return DMXMath.NaryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNary(DXMath.Limit openXmlElement, DMMath.Nary? value, DiffList? diffs, string? objName)
  {
    return DMXMath.NaryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Nary>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNary(DXMath.Limit openXmlElement, DMMath.Nary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Nary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.NaryConverter.CreateOpenXmlElement<DXMath.Nary>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Phantom? GetPhantom(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Phantom>();
    if (element != null)
      return DMXMath.PhantomConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPhantom(DXMath.Limit openXmlElement, DMMath.Phantom? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PhantomConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Phantom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPhantom(DXMath.Limit openXmlElement, DMMath.Phantom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Phantom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PhantomConverter.CreateOpenXmlElement<DXMath.Phantom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Radical? GetRadical(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Radical>();
    if (element != null)
      return DMXMath.RadicalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadical(DXMath.Limit openXmlElement, DMMath.Radical? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RadicalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Radical>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRadical(DXMath.Limit openXmlElement, DMMath.Radical? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Radical>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RadicalConverter.CreateOpenXmlElement<DXMath.Radical>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.PreSubSuper? GetPreSubSuper(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.PreSubSuper>();
    if (element != null)
      return DMXMath.PreSubSuperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreSubSuper(DXMath.Limit openXmlElement, DMMath.PreSubSuper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PreSubSuperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.PreSubSuper>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreSubSuper(DXMath.Limit openXmlElement, DMMath.PreSubSuper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.PreSubSuper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PreSubSuperConverter.CreateOpenXmlElement<DXMath.PreSubSuper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Subscript? GetSubscript(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Subscript>();
    if (element != null)
      return DMXMath.SubscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubscript(DXMath.Limit openXmlElement, DMMath.Subscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Subscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubscript(DXMath.Limit openXmlElement, DMMath.Subscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Subscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubscriptConverter.CreateOpenXmlElement<DXMath.Subscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.SubSuperscript? GetSubSuperscript(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SubSuperscript>();
    if (element != null)
      return DMXMath.SubSuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubSuperscript(DXMath.Limit openXmlElement, DMMath.SubSuperscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubSuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SubSuperscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubSuperscript(DXMath.Limit openXmlElement, DMMath.SubSuperscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubSuperscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubSuperscriptConverter.CreateOpenXmlElement<DXMath.SubSuperscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Superscript? GetSuperscript(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Superscript>();
    if (element != null)
      return DMXMath.SuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperscript(DXMath.Limit openXmlElement, DMMath.Superscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Superscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSuperscript(DXMath.Limit openXmlElement, DMMath.Superscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Superscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SuperscriptConverter.CreateOpenXmlElement<DXMath.Superscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Run? GetRun(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Run>();
    if (element != null)
      return DMXMath.RunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRun(DXMath.Limit openXmlElement, DMMath.Run? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Run>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRun(DXMath.Limit openXmlElement, DMMath.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RunConverter.CreateOpenXmlElement<DXMath.Run>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlRun? GetCustomXmlRun(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlRun>();
    if (element != null)
      return DMXW.CustomXmlRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlRun(DXMath.Limit openXmlElement, DMW.CustomXmlRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlRun(DXMath.Limit openXmlElement, DMW.CustomXmlRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlRunConverter.CreateOpenXmlElement<DXW.CustomXmlRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.SimpleField>? GetSimpleFields(DXMath.Limit openXmlElement)
  {
    var collection = new Collection<DMW.SimpleField>();
    foreach (var item in openXmlElement.Elements<DXW.SimpleField>())
    {
      var newItem = DMXW.SimpleFieldConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSimpleFields(DXMath.Limit openXmlElement, Collection<DMW.SimpleField>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.SimpleField>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.SimpleFieldConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSimpleFields(DXMath.Limit openXmlElement, Collection<DMW.SimpleField>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.SimpleField>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.SimpleFieldConverter.CreateOpenXmlElement<DXW.SimpleField>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.Hyperlink? GetHyperlink(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Hyperlink>();
    if (element != null)
      return DMXW.HyperlinkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlink(DXMath.Limit openXmlElement, DMW.Hyperlink? value, DiffList? diffs, string? objName)
  {
    return DMXW.HyperlinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Hyperlink>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlink(DXMath.Limit openXmlElement, DMW.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HyperlinkConverter.CreateOpenXmlElement<DXW.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtRun? GetSdtRun(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtRun>();
    if (element != null)
      return DMXW.SdtRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtRun(DXMath.Limit openXmlElement, DMW.SdtRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtRun(DXMath.Limit openXmlElement, DMW.SdtRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRunConverter.CreateOpenXmlElement<DXW.SdtRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ProofError? GetProofError(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ProofError>();
    if (element != null)
      return DMXW.ProofErrorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpProofError(DXMath.Limit openXmlElement, DMW.ProofError? value, DiffList? diffs, string? objName)
  {
    return DMXW.ProofErrorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ProofError>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetProofError(DXMath.Limit openXmlElement, DMW.ProofError? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ProofError>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ProofErrorConverter.CreateOpenXmlElement<DXW.ProofError>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermStart? GetPermStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PermStart>();
    if (element != null)
      return DMXW.PermStartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPermStart(DXMath.Limit openXmlElement, DMW.PermStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermStart(DXMath.Limit openXmlElement, DMW.PermStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermStartConverter.CreateOpenXmlElement<DXW.PermStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermEnd? GetPermEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PermEnd>();
    if (element != null)
      return DMXW.PermEndConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPermEnd(DXMath.Limit openXmlElement, DMW.PermEnd? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermEndConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermEnd(DXMath.Limit openXmlElement, DMW.PermEnd? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermEndConverter.CreateOpenXmlElement<DXW.PermEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BookmarkStart? GetBookmarkStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BookmarkStart>();
    if (element != null)
      return DMXW.BookmarkStartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBookmarkStart(DXMath.Limit openXmlElement, DMW.BookmarkStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.BookmarkStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkStart(DXMath.Limit openXmlElement, DMW.BookmarkStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BookmarkStartConverter.CreateOpenXmlElement<DXW.BookmarkStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetBookmarkEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BookmarkEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBookmarkEnd(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkEnd(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.BookmarkEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetCommentRangeStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CommentRangeStart>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentRangeStart(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeStart(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.CommentRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetCommentRangeEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.CommentRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveBookmarkType? GetMoveFromRangeStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>();
    if (element != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRangeStart(DXMath.Limit openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeStart(DXMath.Limit openXmlElement, DMW.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetMoveFromRangeEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveBookmarkType? GetMoveToRangeStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>();
    if (element != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRangeStart(DXMath.Limit openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeStart(DXMath.Limit openXmlElement, DMW.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement<DXW.MoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetMoveToRangeEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlInsRangeStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlInsRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlInsRangeEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlInsRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlDelRangeStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlDelRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlDelRangeEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlDelRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlMoveFromRangeStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveFromRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlMoveFromRangeEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveFromRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlMoveToRangeStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveToRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlMoveToRangeEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveToRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (element != null)
      return DMXW.MarkupType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DXMath.Limit openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (element != null)
      return DMXW.MarkupType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DXMath.Limit openXmlElement, DMW.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.InsertedRun? GetInsertedRun(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsertedRun>();
    if (element != null)
      return DMXW.InsertedRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsertedRun(DXMath.Limit openXmlElement, DMW.InsertedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.InsertedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsertedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsertedRun(DXMath.Limit openXmlElement, DMW.InsertedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsertedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.InsertedRunConverter.CreateOpenXmlElement<DXW.InsertedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DeletedRun? GetDeletedRun(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedRun>();
    if (element != null)
      return DMXW.DeletedRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedRun(DXMath.Limit openXmlElement, DMW.DeletedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeletedRun(DXMath.Limit openXmlElement, DMW.DeletedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DeletedRunConverter.CreateOpenXmlElement<DXW.DeletedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveFromRun? GetMoveFromRun(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRun>();
    if (element != null)
      return DMXW.MoveFromRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRun(DXMath.Limit openXmlElement, DMW.MoveFromRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveFromRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRun(DXMath.Limit openXmlElement, DMW.MoveFromRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveFromRunConverter.CreateOpenXmlElement<DXW.MoveFromRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveToRun? GetMoveToRun(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRun>();
    if (element != null)
      return DMXW.MoveToRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRun(DXMath.Limit openXmlElement, DMW.MoveToRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveToRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRun(DXMath.Limit openXmlElement, DMW.MoveToRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveToRunConverter.CreateOpenXmlElement<DXW.MoveToRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RunConflictInsertion? GetRunConflictInsertion(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (element != null)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunConflictInsertion(DXMath.Limit openXmlElement, DMW.RunConflictInsertion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictInsertionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictInsertion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictInsertion(DXMath.Limit openXmlElement, DMW.RunConflictInsertion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConflictInsertionConverter.CreateOpenXmlElement<DXO2010W.RunConflictInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RunConflictDeletion? GetRunConflictDeletion(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (element != null)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunConflictDeletion(DXMath.Limit openXmlElement, DMW.RunConflictDeletion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictDeletionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictDeletion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictDeletion(DXMath.Limit openXmlElement, DMW.RunConflictDeletion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConflictDeletionConverter.CreateOpenXmlElement<DXO2010W.RunConflictDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Paragraph? GetParagraph(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Paragraph>();
    if (element != null)
      return DMXMath.ParagraphConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraph(DXMath.Limit openXmlElement, DMMath.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ParagraphConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Paragraph>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraph(DXMath.Limit openXmlElement, DMMath.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ParagraphConverter.CreateOpenXmlElement<DXMath.Paragraph>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.OfficeMath? GetOfficeMath(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.OfficeMath>();
    if (element != null)
      return DMXMath.OfficeMathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeMath(DXMath.Limit openXmlElement, DMMath.OfficeMath? value, DiffList? diffs, string? objName)
  {
    return DMXMath.OfficeMathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.OfficeMath>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeMath(DXMath.Limit openXmlElement, DMMath.OfficeMath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.OfficeMath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.OfficeMathConverter.CreateOpenXmlElement<DXMath.OfficeMath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.ControlProperties? GetControlProperties(DXMath.Limit openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.Limit openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlProperties(DXMath.Limit openXmlElement, DMMath.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ControlPropertiesConverter.CreateOpenXmlElement<DXMath.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.Limit? CreateModelElement(DXMath.Limit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Limit();
      value.ArgumentProperties = GetArgumentProperties(openXmlElement);
      value.Accent = GetAccent(openXmlElement);
      value.Bar = GetBar(openXmlElement);
      value.Box = GetBox(openXmlElement);
      value.BorderBox = GetBorderBox(openXmlElement);
      value.Delimiter = GetDelimiter(openXmlElement);
      value.EquationArray = GetEquationArray(openXmlElement);
      value.Fraction = GetFraction(openXmlElement);
      value.MathFunction = GetMathFunction(openXmlElement);
      value.GroupChar = GetGroupChar(openXmlElement);
      value.LimitLower = GetLimitLower(openXmlElement);
      value.LimitUpper = GetLimitUpper(openXmlElement);
      value.Matrix = GetMatrix(openXmlElement);
      value.Nary = GetNary(openXmlElement);
      value.Phantom = GetPhantom(openXmlElement);
      value.Radical = GetRadical(openXmlElement);
      value.PreSubSuper = GetPreSubSuper(openXmlElement);
      value.Subscript = GetSubscript(openXmlElement);
      value.SubSuperscript = GetSubSuperscript(openXmlElement);
      value.Superscript = GetSuperscript(openXmlElement);
      value.Run = GetRun(openXmlElement);
      value.CustomXmlRun = GetCustomXmlRun(openXmlElement);
      value.SimpleFields = GetSimpleFields(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
      value.SdtRun = GetSdtRun(openXmlElement);
      value.ProofError = GetProofError(openXmlElement);
      value.PermStart = GetPermStart(openXmlElement);
      value.PermEnd = GetPermEnd(openXmlElement);
      value.BookmarkStart = GetBookmarkStart(openXmlElement);
      value.BookmarkEnd = GetBookmarkEnd(openXmlElement);
      value.CommentRangeStart = GetCommentRangeStart(openXmlElement);
      value.CommentRangeEnd = GetCommentRangeEnd(openXmlElement);
      value.MoveFromRangeStart = GetMoveFromRangeStart(openXmlElement);
      value.MoveFromRangeEnd = GetMoveFromRangeEnd(openXmlElement);
      value.MoveToRangeStart = GetMoveToRangeStart(openXmlElement);
      value.MoveToRangeEnd = GetMoveToRangeEnd(openXmlElement);
      value.CustomXmlInsRangeStart = GetCustomXmlInsRangeStart(openXmlElement);
      value.CustomXmlInsRangeEnd = GetCustomXmlInsRangeEnd(openXmlElement);
      value.CustomXmlDelRangeStart = GetCustomXmlDelRangeStart(openXmlElement);
      value.CustomXmlDelRangeEnd = GetCustomXmlDelRangeEnd(openXmlElement);
      value.CustomXmlMoveFromRangeStart = GetCustomXmlMoveFromRangeStart(openXmlElement);
      value.CustomXmlMoveFromRangeEnd = GetCustomXmlMoveFromRangeEnd(openXmlElement);
      value.CustomXmlMoveToRangeStart = GetCustomXmlMoveToRangeStart(openXmlElement);
      value.CustomXmlMoveToRangeEnd = GetCustomXmlMoveToRangeEnd(openXmlElement);
      value.CustomXmlConflictInsertionRangeStart = GetCustomXmlConflictInsertionRangeStart(openXmlElement);
      value.CustomXmlConflictInsertionRangeEnd = GetCustomXmlConflictInsertionRangeEnd(openXmlElement);
      value.CustomXmlConflictDeletionRangeStart = GetCustomXmlConflictDeletionRangeStart(openXmlElement);
      value.CustomXmlConflictDeletionRangeEnd = GetCustomXmlConflictDeletionRangeEnd(openXmlElement);
      value.InsertedRun = GetInsertedRun(openXmlElement);
      value.DeletedRun = GetDeletedRun(openXmlElement);
      value.MoveFromRun = GetMoveFromRun(openXmlElement);
      value.MoveToRun = GetMoveToRun(openXmlElement);
      value.RunConflictInsertion = GetRunConflictInsertion(openXmlElement);
      value.RunConflictDeletion = GetRunConflictDeletion(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      value.OfficeMath = GetOfficeMath(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Limit? openXmlElement, DMMath.Limit? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpArgumentProperties(openXmlElement, value.ArgumentProperties, diffs, objName))
        ok = false;
      if (!CmpAccent(openXmlElement, value.Accent, diffs, objName))
        ok = false;
      if (!CmpBar(openXmlElement, value.Bar, diffs, objName))
        ok = false;
      if (!CmpBox(openXmlElement, value.Box, diffs, objName))
        ok = false;
      if (!CmpBorderBox(openXmlElement, value.BorderBox, diffs, objName))
        ok = false;
      if (!CmpDelimiter(openXmlElement, value.Delimiter, diffs, objName))
        ok = false;
      if (!CmpEquationArray(openXmlElement, value.EquationArray, diffs, objName))
        ok = false;
      if (!CmpFraction(openXmlElement, value.Fraction, diffs, objName))
        ok = false;
      if (!CmpMathFunction(openXmlElement, value.MathFunction, diffs, objName))
        ok = false;
      if (!CmpGroupChar(openXmlElement, value.GroupChar, diffs, objName))
        ok = false;
      if (!CmpLimitLower(openXmlElement, value.LimitLower, diffs, objName))
        ok = false;
      if (!CmpLimitUpper(openXmlElement, value.LimitUpper, diffs, objName))
        ok = false;
      if (!CmpMatrix(openXmlElement, value.Matrix, diffs, objName))
        ok = false;
      if (!CmpNary(openXmlElement, value.Nary, diffs, objName))
        ok = false;
      if (!CmpPhantom(openXmlElement, value.Phantom, diffs, objName))
        ok = false;
      if (!CmpRadical(openXmlElement, value.Radical, diffs, objName))
        ok = false;
      if (!CmpPreSubSuper(openXmlElement, value.PreSubSuper, diffs, objName))
        ok = false;
      if (!CmpSubscript(openXmlElement, value.Subscript, diffs, objName))
        ok = false;
      if (!CmpSubSuperscript(openXmlElement, value.SubSuperscript, diffs, objName))
        ok = false;
      if (!CmpSuperscript(openXmlElement, value.Superscript, diffs, objName))
        ok = false;
      if (!CmpRun(openXmlElement, value.Run, diffs, objName))
        ok = false;
      if (!CmpCustomXmlRun(openXmlElement, value.CustomXmlRun, diffs, objName))
        ok = false;
      if (!CmpSimpleFields(openXmlElement, value.SimpleFields, diffs, objName))
        ok = false;
      if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName))
        ok = false;
      if (!CmpSdtRun(openXmlElement, value.SdtRun, diffs, objName))
        ok = false;
      if (!CmpProofError(openXmlElement, value.ProofError, diffs, objName))
        ok = false;
      if (!CmpPermStart(openXmlElement, value.PermStart, diffs, objName))
        ok = false;
      if (!CmpPermEnd(openXmlElement, value.PermEnd, diffs, objName))
        ok = false;
      if (!CmpBookmarkStart(openXmlElement, value.BookmarkStart, diffs, objName))
        ok = false;
      if (!CmpBookmarkEnd(openXmlElement, value.BookmarkEnd, diffs, objName))
        ok = false;
      if (!CmpCommentRangeStart(openXmlElement, value.CommentRangeStart, diffs, objName))
        ok = false;
      if (!CmpCommentRangeEnd(openXmlElement, value.CommentRangeEnd, diffs, objName))
        ok = false;
      if (!CmpMoveFromRangeStart(openXmlElement, value.MoveFromRangeStart, diffs, objName))
        ok = false;
      if (!CmpMoveFromRangeEnd(openXmlElement, value.MoveFromRangeEnd, diffs, objName))
        ok = false;
      if (!CmpMoveToRangeStart(openXmlElement, value.MoveToRangeStart, diffs, objName))
        ok = false;
      if (!CmpMoveToRangeEnd(openXmlElement, value.MoveToRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlInsRangeStart(openXmlElement, value.CustomXmlInsRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlInsRangeEnd(openXmlElement, value.CustomXmlInsRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlDelRangeStart(openXmlElement, value.CustomXmlDelRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlDelRangeEnd(openXmlElement, value.CustomXmlDelRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveFromRangeStart(openXmlElement, value.CustomXmlMoveFromRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveFromRangeEnd(openXmlElement, value.CustomXmlMoveFromRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveToRangeStart(openXmlElement, value.CustomXmlMoveToRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveToRangeEnd(openXmlElement, value.CustomXmlMoveToRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictInsertionRangeStart(openXmlElement, value.CustomXmlConflictInsertionRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictInsertionRangeEnd(openXmlElement, value.CustomXmlConflictInsertionRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictDeletionRangeStart(openXmlElement, value.CustomXmlConflictDeletionRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictDeletionRangeEnd(openXmlElement, value.CustomXmlConflictDeletionRangeEnd, diffs, objName))
        ok = false;
      if (!CmpInsertedRun(openXmlElement, value.InsertedRun, diffs, objName))
        ok = false;
      if (!CmpDeletedRun(openXmlElement, value.DeletedRun, diffs, objName))
        ok = false;
      if (!CmpMoveFromRun(openXmlElement, value.MoveFromRun, diffs, objName))
        ok = false;
      if (!CmpMoveToRun(openXmlElement, value.MoveToRun, diffs, objName))
        ok = false;
      if (!CmpRunConflictInsertion(openXmlElement, value.RunConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpRunConflictDeletion(openXmlElement, value.RunConflictDeletion, diffs, objName))
        ok = false;
      if (!CmpParagraph(openXmlElement, value.Paragraph, diffs, objName))
        ok = false;
      if (!CmpOfficeMath(openXmlElement, value.OfficeMath, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Limit value)
    where OpenXmlElementType: DXMath.Limit, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Limit openXmlElement, DMMath.Limit value)
  {
    SetArgumentProperties(openXmlElement, value?.ArgumentProperties);
    SetAccent(openXmlElement, value?.Accent);
    SetBar(openXmlElement, value?.Bar);
    SetBox(openXmlElement, value?.Box);
    SetBorderBox(openXmlElement, value?.BorderBox);
    SetDelimiter(openXmlElement, value?.Delimiter);
    SetEquationArray(openXmlElement, value?.EquationArray);
    SetFraction(openXmlElement, value?.Fraction);
    SetMathFunction(openXmlElement, value?.MathFunction);
    SetGroupChar(openXmlElement, value?.GroupChar);
    SetLimitLower(openXmlElement, value?.LimitLower);
    SetLimitUpper(openXmlElement, value?.LimitUpper);
    SetMatrix(openXmlElement, value?.Matrix);
    SetNary(openXmlElement, value?.Nary);
    SetPhantom(openXmlElement, value?.Phantom);
    SetRadical(openXmlElement, value?.Radical);
    SetPreSubSuper(openXmlElement, value?.PreSubSuper);
    SetSubscript(openXmlElement, value?.Subscript);
    SetSubSuperscript(openXmlElement, value?.SubSuperscript);
    SetSuperscript(openXmlElement, value?.Superscript);
    SetRun(openXmlElement, value?.Run);
    SetCustomXmlRun(openXmlElement, value?.CustomXmlRun);
    SetSimpleFields(openXmlElement, value?.SimpleFields);
    SetHyperlink(openXmlElement, value?.Hyperlink);
    SetSdtRun(openXmlElement, value?.SdtRun);
    SetProofError(openXmlElement, value?.ProofError);
    SetPermStart(openXmlElement, value?.PermStart);
    SetPermEnd(openXmlElement, value?.PermEnd);
    SetBookmarkStart(openXmlElement, value?.BookmarkStart);
    SetBookmarkEnd(openXmlElement, value?.BookmarkEnd);
    SetCommentRangeStart(openXmlElement, value?.CommentRangeStart);
    SetCommentRangeEnd(openXmlElement, value?.CommentRangeEnd);
    SetMoveFromRangeStart(openXmlElement, value?.MoveFromRangeStart);
    SetMoveFromRangeEnd(openXmlElement, value?.MoveFromRangeEnd);
    SetMoveToRangeStart(openXmlElement, value?.MoveToRangeStart);
    SetMoveToRangeEnd(openXmlElement, value?.MoveToRangeEnd);
    SetCustomXmlInsRangeStart(openXmlElement, value?.CustomXmlInsRangeStart);
    SetCustomXmlInsRangeEnd(openXmlElement, value?.CustomXmlInsRangeEnd);
    SetCustomXmlDelRangeStart(openXmlElement, value?.CustomXmlDelRangeStart);
    SetCustomXmlDelRangeEnd(openXmlElement, value?.CustomXmlDelRangeEnd);
    SetCustomXmlMoveFromRangeStart(openXmlElement, value?.CustomXmlMoveFromRangeStart);
    SetCustomXmlMoveFromRangeEnd(openXmlElement, value?.CustomXmlMoveFromRangeEnd);
    SetCustomXmlMoveToRangeStart(openXmlElement, value?.CustomXmlMoveToRangeStart);
    SetCustomXmlMoveToRangeEnd(openXmlElement, value?.CustomXmlMoveToRangeEnd);
    SetCustomXmlConflictInsertionRangeStart(openXmlElement, value?.CustomXmlConflictInsertionRangeStart);
    SetCustomXmlConflictInsertionRangeEnd(openXmlElement, value?.CustomXmlConflictInsertionRangeEnd);
    SetCustomXmlConflictDeletionRangeStart(openXmlElement, value?.CustomXmlConflictDeletionRangeStart);
    SetCustomXmlConflictDeletionRangeEnd(openXmlElement, value?.CustomXmlConflictDeletionRangeEnd);
    SetInsertedRun(openXmlElement, value?.InsertedRun);
    SetDeletedRun(openXmlElement, value?.DeletedRun);
    SetMoveFromRun(openXmlElement, value?.MoveFromRun);
    SetMoveToRun(openXmlElement, value?.MoveToRun);
    SetRunConflictInsertion(openXmlElement, value?.RunConflictInsertion);
    SetRunConflictDeletion(openXmlElement, value?.RunConflictDeletion);
    SetParagraph(openXmlElement, value?.Paragraph);
    SetOfficeMath(openXmlElement, value?.OfficeMath);
    SetControlProperties(openXmlElement, value?.ControlProperties);
  }
}
