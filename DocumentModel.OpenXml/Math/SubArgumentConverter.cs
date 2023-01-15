using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Math;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using BookmarkStart = DocumentModel.Wordprocessing.BookmarkStart;
using CustomXmlRun = DocumentModel.Wordprocessing.CustomXmlRun;
using DeletedRun = DocumentModel.Wordprocessing.DeletedRun;
using InsertedRun = DocumentModel.Wordprocessing.InsertedRun;
using MarkupRangeType = DocumentModel.Wordprocessing.MarkupRangeType;
using MarkupType = DocumentModel.Wordprocessing.MarkupType;
using MoveBookmarkType = DocumentModel.Wordprocessing.MoveBookmarkType;
using MoveFromRun = DocumentModel.Wordprocessing.MoveFromRun;
using MoveToRun = DocumentModel.Wordprocessing.MoveToRun;
using OfficeMath = DocumentModel.Math.OfficeMath;
using Paragraph = DocumentModel.Math.Paragraph;
using PermEnd = DocumentModel.Wordprocessing.PermEnd;
using PermStart = DocumentModel.Wordprocessing.PermStart;
using ProofError = DocumentModel.Wordprocessing.ProofError;
using Run = DocumentModel.Math.Run;
using RunConflictDeletion = DocumentModel.Wordprocessing.RunConflictDeletion;
using RunConflictInsertion = DocumentModel.Wordprocessing.RunConflictInsertion;
using SdtRun = DocumentModel.Wordprocessing.SdtRun;
using SimpleField = DocumentModel.Wordprocessing.SimpleField;
using SubArgument = DocumentFormat.OpenXml.Math.SubArgument;
using TrackChangeType = DocumentModel.Wordprocessing.TrackChangeType;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Lower limit (n-ary) .
/// </summary>
public static class SubArgumentConverter
{
  public static ArgumentProperties? GetArgumentProperties(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
    if (itemElement != null)
      return ArgumentPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArgumentProperties(SubArgument? openXmlElement, ArgumentProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArgumentPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ArgumentProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Accent? GetAccent(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Accent>();
    if (itemElement != null)
      return AccentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAccent(SubArgument? openXmlElement, Accent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Accent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AccentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Accent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Bar? GetBar(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Bar>();
    if (itemElement != null)
      return BarConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBar(SubArgument? openXmlElement, Bar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Bar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Bar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.Box? GetBox(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
    if (itemElement != null)
      return BoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBox(SubArgument? openXmlElement, DocumentModel.Math.Box? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Box>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BorderBox? GetBorderBox(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBox>();
    if (itemElement != null)
      return BorderBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBorderBox(SubArgument? openXmlElement, BorderBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BorderBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Delimiter? GetDelimiter(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Delimiter>();
    if (itemElement != null)
      return DelimiterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDelimiter(SubArgument? openXmlElement, Delimiter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Delimiter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DelimiterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Delimiter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EquationArray? GetEquationArray(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArray>();
    if (itemElement != null)
      return EquationArrayConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEquationArray(SubArgument? openXmlElement, EquationArray? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArray>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EquationArrayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.EquationArray>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Fraction? GetFraction(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Fraction>();
    if (itemElement != null)
      return FractionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFraction(SubArgument? openXmlElement, Fraction? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Fraction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FractionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Fraction>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MathFunction? GetMathFunction(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MathFunction>();
    if (itemElement != null)
      return MathFunctionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMathFunction(SubArgument? openXmlElement, MathFunction? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathFunction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MathFunctionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MathFunction>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static GroupChar? GetGroupChar(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.GroupChar>();
    if (itemElement != null)
      return GroupCharConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroupChar(SubArgument? openXmlElement, GroupChar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GroupChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupCharConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.GroupChar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LimitLower? GetLimitLower(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLower>();
    if (itemElement != null)
      return LimitLowerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimitLower(SubArgument? openXmlElement, LimitLower? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLower>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitLowerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLower>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LimitUpper? GetLimitUpper(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpper>();
    if (itemElement != null)
      return LimitUpperConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimitUpper(SubArgument? openXmlElement, LimitUpper? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpper>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitUpperConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitUpper>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Matrix? GetMatrix(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Matrix>();
    if (itemElement != null)
      return MatrixConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMatrix(SubArgument? openXmlElement, Matrix? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Matrix>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MatrixConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Matrix>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Nary? GetNary(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Nary>();
    if (itemElement != null)
      return NaryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNary(SubArgument? openXmlElement, Nary? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Nary>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NaryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Nary>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Phantom? GetPhantom(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Phantom>();
    if (itemElement != null)
      return PhantomConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPhantom(SubArgument? openXmlElement, Phantom? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Phantom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PhantomConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Phantom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Radical? GetRadical(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Radical>();
    if (itemElement != null)
      return RadicalConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadical(SubArgument? openXmlElement, Radical? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Radical>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadicalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Radical>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PreSubSuper? GetPreSubSuper(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
    if (itemElement != null)
      return PreSubSuperConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreSubSuper(SubArgument? openXmlElement, PreSubSuper? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreSubSuperConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.PreSubSuper>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Subscript? GetSubscript(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Subscript>();
    if (itemElement != null)
      return SubscriptConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubscript(SubArgument? openXmlElement, Subscript? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Subscript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Subscript>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SubSuperscript? GetSubSuperscript(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
    if (itemElement != null)
      return SubSuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubSuperscript(SubArgument? openXmlElement, SubSuperscript? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubSuperscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SubSuperscript>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Superscript? GetSuperscript(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Superscript>();
    if (itemElement != null)
      return SuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSuperscript(SubArgument? openXmlElement, Superscript? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Superscript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuperscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Superscript>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Run? GetRun(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
    if (itemElement != null)
      return RunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRun(SubArgument? openXmlElement, Run? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Run>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CustomXmlRun? GetCustomXmlRun(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
    if (itemElement != null)
      return CustomXmlRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlRun(SubArgument? openXmlElement, CustomXmlRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomXmlRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<SimpleField>? GetSimpleFields(SubArgument? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SimpleField>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.SimpleField>())
      {
        var newItem = SimpleFieldConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSimpleFields(SubArgument? openXmlElement, Collection<SimpleField>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.SimpleField>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SimpleFieldConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SimpleField>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Hyperlink? GetHyperlink(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
    if (itemElement != null)
      return Wordprocessing.HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlink(SubArgument? openXmlElement, DocumentModel.Wordprocessing.Hyperlink? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Wordprocessing.HyperlinkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtRun? GetSdtRun(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
    if (itemElement != null)
      return SdtRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtRun(SubArgument? openXmlElement, SdtRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ProofError? GetProofError(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetProofError(SubArgument? openXmlElement, ProofError? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ProofErrorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PermStart? GetPermStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return PermStartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPermStart(SubArgument? openXmlElement, PermStart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PermStartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PermEnd? GetPermEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return PermEndConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPermEnd(SubArgument? openXmlElement, PermEnd? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PermEndConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PermEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BookmarkStart? GetBookmarkStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBookmarkStart(SubArgument? openXmlElement, BookmarkStart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BookmarkStartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetBookmarkEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BookmarkEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBookmarkEnd(SubArgument? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BookmarkEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<BookmarkEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetCommentRangeStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CommentRangeStart>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentRangeStart(SubArgument? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CommentRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<CommentRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetCommentRangeEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CommentRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentRangeEnd(SubArgument? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CommentRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<CommentRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveBookmarkType? GetMoveFromRangeStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveFromRangeStart>();
    if (itemElement != null)
      return MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRangeStart(SubArgument? openXmlElement, MoveBookmarkType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveFromRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveBookmarkTypeConverter.CreateOpenXmlElement<MoveFromRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetMoveFromRangeEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveFromRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRangeEnd(SubArgument? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveFromRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<MoveFromRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveBookmarkType? GetMoveToRangeStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveToRangeStart>();
    if (itemElement != null)
      return MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRangeStart(SubArgument? openXmlElement, MoveBookmarkType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveToRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveBookmarkTypeConverter.CreateOpenXmlElement<MoveToRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupRangeType? GetMoveToRangeEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveToRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRangeEnd(SubArgument? openXmlElement, MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MoveToRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupRangeTypeConverter.CreateOpenXmlElement<MoveToRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetCustomXmlInsRangeStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlInsRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlInsRangeStart(SubArgument? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlInsRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<CustomXmlInsRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType? GetCustomXmlInsRangeEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlInsRangeEnd(SubArgument? openXmlElement, MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlInsRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupTypeConverter.CreateOpenXmlElement<CustomXmlInsRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetCustomXmlDelRangeStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlDelRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlDelRangeStart(SubArgument? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlDelRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<CustomXmlDelRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType? GetCustomXmlDelRangeEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlDelRangeEnd(SubArgument? openXmlElement, MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlDelRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupTypeConverter.CreateOpenXmlElement<CustomXmlDelRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetCustomXmlMoveFromRangeStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveFromRangeStart(SubArgument? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlMoveFromRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<CustomXmlMoveFromRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType? GetCustomXmlMoveFromRangeEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveFromRangeEnd(SubArgument? openXmlElement, MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlMoveFromRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupTypeConverter.CreateOpenXmlElement<CustomXmlMoveFromRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType? GetCustomXmlMoveToRangeStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveToRangeStart(SubArgument? openXmlElement, TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlMoveToRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeTypeConverter.CreateOpenXmlElement<CustomXmlMoveToRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType? GetCustomXmlMoveToRangeEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveToRangeEnd(SubArgument? openXmlElement, MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlMoveToRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupTypeConverter.CreateOpenXmlElement<CustomXmlMoveToRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictInsertionRangeStart(SubArgument? openXmlElement, TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlConflictInsertionRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeType2Converter.CreateOpenXmlElement<CustomXmlConflictInsertionRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType2? GetCustomXmlConflictInsertionRangeEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictInsertionRangeEnd(SubArgument? openXmlElement, MarkupType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlConflictInsertionRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupType2Converter.CreateOpenXmlElement<CustomXmlConflictInsertionRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictDeletionRangeStart(SubArgument? openXmlElement, TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlConflictDeletionRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrackChangeType2Converter.CreateOpenXmlElement<CustomXmlConflictDeletionRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MarkupType2? GetCustomXmlConflictDeletionRangeEnd(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictDeletionRangeEnd(SubArgument? openXmlElement, MarkupType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomXmlConflictDeletionRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkupType2Converter.CreateOpenXmlElement<CustomXmlConflictDeletionRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static InsertedRun? GetInsertedRun(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      return InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsertedRun(SubArgument? openXmlElement, InsertedRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InsertedRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DeletedRun? GetDeletedRun(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      return DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeletedRun(SubArgument? openXmlElement, DeletedRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DeletedRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveFromRun? GetMoveFromRun(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      return MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRun(SubArgument? openXmlElement, MoveFromRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveFromRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveToRun? GetMoveToRun(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      return MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRun(SubArgument? openXmlElement, MoveToRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveToRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RunConflictInsertion? GetRunConflictInsertion(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      return RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunConflictInsertion(SubArgument? openXmlElement, RunConflictInsertion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunConflictInsertionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RunConflictDeletion? GetRunConflictDeletion(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      return RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunConflictDeletion(SubArgument? openXmlElement, RunConflictDeletion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunConflictDeletionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Paragraph? GetParagraph(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
    if (itemElement != null)
      return ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraph(SubArgument? openXmlElement, Paragraph? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Paragraph>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OfficeMath? GetOfficeMath(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
    if (itemElement != null)
      return OfficeMathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeMath(SubArgument? openXmlElement, OfficeMath? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeMathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.OfficeMath>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ControlProperties? GetControlProperties(SubArgument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlProperties(SubArgument? openXmlElement, ControlProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.SubArgument? CreateModelElement(SubArgument? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.SubArgument();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.SubArgument? value)
    where OpenXmlElementType : SubArgument, new()
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