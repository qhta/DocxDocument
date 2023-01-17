namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Upper limit (n-ary).
/// </summary>
public static class SuperArgumentConverter
{
  private static DocumentModel.Math.ArgumentProperties? GetArgumentProperties(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ArgumentPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArgumentProperties(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.ArgumentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.ArgumentPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ArgumentProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Accent? GetAccent(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Accent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.AccentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAccent(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Accent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Accent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.AccentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Accent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Bar? GetBar(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Bar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBar(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Bar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Bar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.BarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Bar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Box? GetBox(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBox(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.BoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Box>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.BorderBox? GetBorderBox(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BorderBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBorderBox(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.BorderBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.BorderBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BorderBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Delimiter? GetDelimiter(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Delimiter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.DelimiterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDelimiter(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Delimiter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Delimiter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.DelimiterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Delimiter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.EquationArray? GetEquationArray(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArray>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.EquationArrayConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEquationArray(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.EquationArray? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArray>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.EquationArrayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.EquationArray>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Fraction? GetFraction(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Fraction>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.FractionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFraction(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Fraction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Fraction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.FractionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Fraction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.MathFunction? GetMathFunction(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MathFunction>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.MathFunctionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMathFunction(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.MathFunction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathFunction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.MathFunctionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MathFunction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.GroupChar? GetGroupChar(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.GroupChar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.GroupCharConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupChar(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.GroupChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GroupChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.GroupCharConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.GroupChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.LimitLower? GetLimitLower(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLower>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitLowerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLimitLower(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.LimitLower? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLower>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.LimitLowerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLower>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.LimitUpper? GetLimitUpper(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpper>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitUpperConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLimitUpper(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.LimitUpper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.LimitUpperConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitUpper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Matrix? GetMatrix(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Matrix>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.MatrixConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMatrix(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Matrix? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Matrix>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.MatrixConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Matrix>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Nary? GetNary(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Nary>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.NaryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNary(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Nary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Nary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.NaryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Nary>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Phantom? GetPhantom(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Phantom>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.PhantomConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPhantom(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Phantom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Phantom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.PhantomConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Phantom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Radical? GetRadical(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Radical>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.RadicalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRadical(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Radical? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Radical>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.RadicalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Radical>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.PreSubSuper? GetPreSubSuper(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.PreSubSuperConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreSubSuper(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.PreSubSuper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.PreSubSuperConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.PreSubSuper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Subscript? GetSubscript(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Subscript>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubscriptConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSubscript(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Subscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Subscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.SubscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Subscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.SubSuperscript? GetSubSuperscript(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubSuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSubSuperscript(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.SubSuperscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.SubSuperscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SubSuperscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Superscript? GetSuperscript(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Superscript>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSuperscript(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Superscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Superscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.SuperscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Superscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Run? GetRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.RunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.RunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Run>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.CustomXmlRun? GetCustomXmlRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CustomXmlRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.CustomXmlRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.CustomXmlRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.SimpleField> GetSimpleFields(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.SimpleField>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.SimpleField>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.SimpleFieldConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetSimpleFields(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.SimpleField>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.SimpleField>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.SimpleFieldConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SimpleField>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Wordprocessing.Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlink(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.HyperlinkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtRun? GetSdtRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.SdtRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.ProofError? GetProofError(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetProofError(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.ProofError? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ProofErrorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.PermStart? GetPermStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPermStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.PermStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PermStartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.PermEnd? GetPermEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermEndConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPermEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.PermEnd? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PermEndConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PermEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.BookmarkStart? GetBookmarkStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBookmarkStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.BookmarkStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.BookmarkStartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetBookmarkEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBookmarkEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCommentRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCommentRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveFromRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveFromRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveToRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveToRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.InsertedRun? GetInsertedRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInsertedRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.InsertedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.InsertedRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.DeletedRun? GetDeletedRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.DeletedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DeletedRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MoveFromRun? GetMoveFromRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MoveFromRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MoveFromRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.MoveToRun? GetMoveToRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToRun(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.MoveToRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MoveToRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.RunConflictInsertion? GetRunConflictInsertion(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunConflictInsertion(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.RunConflictInsertion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunConflictInsertionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.RunConflictDeletion? GetRunConflictDeletion(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunConflictDeletion(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Wordprocessing.RunConflictDeletion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunConflictDeletionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Paragraph? GetParagraph(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraph(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.ParagraphConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Paragraph>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.OfficeMath? GetOfficeMath(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.OfficeMathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeMath(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.OfficeMath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.OfficeMathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.OfficeMath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DocumentFormat.OpenXml.Math.SuperArgument openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.SuperArgument? CreateModelElement(DocumentFormat.OpenXml.Math.SuperArgument? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.SuperArgument();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.SuperArgument? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.SuperArgument, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
