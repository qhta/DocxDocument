using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Math;
using DocumentModel.OpenXml.Math;
using DocumentModel.Wordprocessing;
using BookmarkStart = DocumentModel.Wordprocessing.BookmarkStart;
using CustomXmlRuby = DocumentModel.Wordprocessing.CustomXmlRuby;
using DeletedRun = DocumentModel.Wordprocessing.DeletedRun;
using HyperlinkRuby = DocumentModel.Wordprocessing.HyperlinkRuby;
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
using Run = DocumentModel.Wordprocessing.Run;
using RunConflictDeletion = DocumentModel.Wordprocessing.RunConflictDeletion;
using RunConflictInsertion = DocumentModel.Wordprocessing.RunConflictInsertion;
using SdtRunRuby = DocumentModel.Wordprocessing.SdtRunRuby;
using SimpleFieldRuby = DocumentFormat.OpenXml.Wordprocessing.SimpleFieldRuby;
using TrackChangeType = DocumentModel.Wordprocessing.TrackChangeType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SimpleFieldRuby Class.
/// </summary>
public static class SimpleFieldRubyConverter
{
  /// <summary>
  ///   instr
  /// </summary>
  public static String? GetInstruction(SimpleFieldRuby? openXmlElement)
  {
    return openXmlElement?.Instruction?.Value;
  }

  public static void SetInstruction(SimpleFieldRuby? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Instruction = new StringValue { Value = value };
      else
        openXmlElement.Instruction = null;
  }

  /// <summary>
  ///   fldLock
  /// </summary>
  public static Boolean? GetFieldLock(SimpleFieldRuby? openXmlElement)
  {
    return openXmlElement?.FieldLock?.Value;
  }

  public static void SetFieldLock(SimpleFieldRuby? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FieldLock = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.FieldLock = null;
  }

  /// <summary>
  ///   dirty
  /// </summary>
  public static Boolean? GetDirty(SimpleFieldRuby? openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }

  public static void SetDirty(SimpleFieldRuby? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Dirty = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Dirty = null;
  }

  /// <summary>
  ///   FieldData.
  /// </summary>
  public static String? GetFieldData(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FieldData>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFieldData(SimpleFieldRuby? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FieldData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FieldData { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CustomXmlRuby? GetCustomXmlRuby(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRuby>();
    if (itemElement != null)
      return CustomXmlRubyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlRuby(SimpleFieldRuby? openXmlElement, CustomXmlRuby? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRuby>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomXmlRubyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRuby>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SimpleFieldRuby? GetChildSimpleFieldRuby(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SimpleFieldRuby>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildSimpleFieldRuby(SimpleFieldRuby? openXmlElement, DocumentModel.Wordprocessing.SimpleFieldRuby? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SimpleFieldRuby>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<SimpleFieldRuby>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HyperlinkRuby? GetHyperlinkRuby(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HyperlinkRuby>();
    if (itemElement != null)
      return HyperlinkRubyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlinkRuby(SimpleFieldRuby? openXmlElement, HyperlinkRuby? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HyperlinkRuby>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkRubyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HyperlinkRuby>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Run? GetRun(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Run>();
    if (itemElement != null)
      return RunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRun(SimpleFieldRuby? openXmlElement, Run? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Run>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Run>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtRunRuby? GetSdtRunRuby(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby>();
    if (itemElement != null)
      return SdtRunRubyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtRunRuby(SimpleFieldRuby? openXmlElement, SdtRunRuby? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtRunRubyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ProofError? GetProofError(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetProofError(SimpleFieldRuby? openXmlElement, ProofError? value)
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

  public static PermStart? GetPermStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return PermStartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPermStart(SimpleFieldRuby? openXmlElement, PermStart? value)
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

  public static PermEnd? GetPermEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return PermEndConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPermEnd(SimpleFieldRuby? openXmlElement, PermEnd? value)
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

  public static BookmarkStart? GetBookmarkStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBookmarkStart(SimpleFieldRuby? openXmlElement, BookmarkStart? value)
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

  public static MarkupRangeType? GetBookmarkEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BookmarkEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBookmarkEnd(SimpleFieldRuby? openXmlElement, MarkupRangeType? value)
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

  public static MarkupRangeType? GetCommentRangeStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CommentRangeStart>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentRangeStart(SimpleFieldRuby? openXmlElement, MarkupRangeType? value)
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

  public static MarkupRangeType? GetCommentRangeEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CommentRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentRangeEnd(SimpleFieldRuby? openXmlElement, MarkupRangeType? value)
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

  public static MoveBookmarkType? GetMoveFromRangeStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveFromRangeStart>();
    if (itemElement != null)
      return MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRangeStart(SimpleFieldRuby? openXmlElement, MoveBookmarkType? value)
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

  public static MarkupRangeType? GetMoveFromRangeEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveFromRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRangeEnd(SimpleFieldRuby? openXmlElement, MarkupRangeType? value)
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

  public static MoveBookmarkType? GetMoveToRangeStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveToRangeStart>();
    if (itemElement != null)
      return MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRangeStart(SimpleFieldRuby? openXmlElement, MoveBookmarkType? value)
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

  public static MarkupRangeType? GetMoveToRangeEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveToRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRangeEnd(SimpleFieldRuby? openXmlElement, MarkupRangeType? value)
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

  public static TrackChangeType? GetCustomXmlInsRangeStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlInsRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlInsRangeStart(SimpleFieldRuby? openXmlElement, TrackChangeType? value)
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

  public static MarkupType? GetCustomXmlInsRangeEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlInsRangeEnd(SimpleFieldRuby? openXmlElement, MarkupType? value)
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

  public static TrackChangeType? GetCustomXmlDelRangeStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlDelRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlDelRangeStart(SimpleFieldRuby? openXmlElement, TrackChangeType? value)
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

  public static MarkupType? GetCustomXmlDelRangeEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlDelRangeEnd(SimpleFieldRuby? openXmlElement, MarkupType? value)
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

  public static TrackChangeType? GetCustomXmlMoveFromRangeStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveFromRangeStart(SimpleFieldRuby? openXmlElement, TrackChangeType? value)
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

  public static MarkupType? GetCustomXmlMoveFromRangeEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveFromRangeEnd(SimpleFieldRuby? openXmlElement, MarkupType? value)
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

  public static TrackChangeType? GetCustomXmlMoveToRangeStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveToRangeStart(SimpleFieldRuby? openXmlElement, TrackChangeType? value)
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

  public static MarkupType? GetCustomXmlMoveToRangeEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveToRangeEnd(SimpleFieldRuby? openXmlElement, MarkupType? value)
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

  public static TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictInsertionRangeStart(SimpleFieldRuby? openXmlElement, TrackChangeType2? value)
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

  public static MarkupType2? GetCustomXmlConflictInsertionRangeEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictInsertionRangeEnd(SimpleFieldRuby? openXmlElement, MarkupType2? value)
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

  public static TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictDeletionRangeStart(SimpleFieldRuby? openXmlElement, TrackChangeType2? value)
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

  public static MarkupType2? GetCustomXmlConflictDeletionRangeEnd(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictDeletionRangeEnd(SimpleFieldRuby? openXmlElement, MarkupType2? value)
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

  public static InsertedRun? GetInsertedRun(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      return InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsertedRun(SimpleFieldRuby? openXmlElement, InsertedRun? value)
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

  public static DeletedRun? GetDeletedRun(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      return DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeletedRun(SimpleFieldRuby? openXmlElement, DeletedRun? value)
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

  public static MoveFromRun? GetMoveFromRun(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      return MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRun(SimpleFieldRuby? openXmlElement, MoveFromRun? value)
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

  public static MoveToRun? GetMoveToRun(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      return MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRun(SimpleFieldRuby? openXmlElement, MoveToRun? value)
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

  public static RunConflictInsertion? GetRunConflictInsertion(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      return RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunConflictInsertion(SimpleFieldRuby? openXmlElement, RunConflictInsertion? value)
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

  public static RunConflictDeletion? GetRunConflictDeletion(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      return RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunConflictDeletion(SimpleFieldRuby? openXmlElement, RunConflictDeletion? value)
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

  public static Paragraph? GetParagraph(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
    if (itemElement != null)
      return Math.ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraph(SimpleFieldRuby? openXmlElement, Paragraph? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Math.ParagraphConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Paragraph>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OfficeMath? GetOfficeMath(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
    if (itemElement != null)
      return OfficeMathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeMath(SimpleFieldRuby? openXmlElement, OfficeMath? value)
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

  public static Accent? GetAccent(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Accent>();
    if (itemElement != null)
      return AccentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAccent(SimpleFieldRuby? openXmlElement, Accent? value)
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

  public static Bar? GetBar(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Bar>();
    if (itemElement != null)
      return BarConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBar(SimpleFieldRuby? openXmlElement, Bar? value)
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

  public static DocumentModel.Math.Box? GetBox(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
    if (itemElement != null)
      return Math.BoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBox(SimpleFieldRuby? openXmlElement, DocumentModel.Math.Box? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Math.BoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Box>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BorderBox? GetBorderBox(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBox>();
    if (itemElement != null)
      return BorderBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBorderBox(SimpleFieldRuby? openXmlElement, BorderBox? value)
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

  public static Delimiter? GetDelimiter(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Delimiter>();
    if (itemElement != null)
      return DelimiterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDelimiter(SimpleFieldRuby? openXmlElement, Delimiter? value)
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

  public static EquationArray? GetEquationArray(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArray>();
    if (itemElement != null)
      return EquationArrayConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEquationArray(SimpleFieldRuby? openXmlElement, EquationArray? value)
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

  public static Fraction? GetFraction(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Fraction>();
    if (itemElement != null)
      return FractionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFraction(SimpleFieldRuby? openXmlElement, Fraction? value)
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

  public static MathFunction? GetMathFunction(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MathFunction>();
    if (itemElement != null)
      return MathFunctionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMathFunction(SimpleFieldRuby? openXmlElement, MathFunction? value)
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

  public static GroupChar? GetGroupChar(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.GroupChar>();
    if (itemElement != null)
      return GroupCharConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroupChar(SimpleFieldRuby? openXmlElement, GroupChar? value)
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

  public static LimitLower? GetLimitLower(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLower>();
    if (itemElement != null)
      return LimitLowerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimitLower(SimpleFieldRuby? openXmlElement, LimitLower? value)
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

  public static LimitUpper? GetLimitUpper(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpper>();
    if (itemElement != null)
      return LimitUpperConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimitUpper(SimpleFieldRuby? openXmlElement, LimitUpper? value)
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

  public static Matrix? GetMatrix(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Matrix>();
    if (itemElement != null)
      return MatrixConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMatrix(SimpleFieldRuby? openXmlElement, Matrix? value)
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

  public static Nary? GetNary(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Nary>();
    if (itemElement != null)
      return NaryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNary(SimpleFieldRuby? openXmlElement, Nary? value)
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

  public static Phantom? GetPhantom(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Phantom>();
    if (itemElement != null)
      return PhantomConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPhantom(SimpleFieldRuby? openXmlElement, Phantom? value)
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

  public static Radical? GetRadical(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Radical>();
    if (itemElement != null)
      return RadicalConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadical(SimpleFieldRuby? openXmlElement, Radical? value)
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

  public static PreSubSuper? GetPreSubSuper(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
    if (itemElement != null)
      return PreSubSuperConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreSubSuper(SimpleFieldRuby? openXmlElement, PreSubSuper? value)
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

  public static Subscript? GetSubscript(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Subscript>();
    if (itemElement != null)
      return SubscriptConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubscript(SimpleFieldRuby? openXmlElement, Subscript? value)
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

  public static SubSuperscript? GetSubSuperscript(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
    if (itemElement != null)
      return SubSuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubSuperscript(SimpleFieldRuby? openXmlElement, SubSuperscript? value)
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

  public static Superscript? GetSuperscript(SimpleFieldRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Superscript>();
    if (itemElement != null)
      return SuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSuperscript(SimpleFieldRuby? openXmlElement, Superscript? value)
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

  public static DocumentModel.Wordprocessing.SimpleFieldRuby? CreateModelElement(SimpleFieldRuby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SimpleFieldRuby();
      value.Instruction = GetInstruction(openXmlElement);
      value.FieldLock = GetFieldLock(openXmlElement);
      value.Dirty = GetDirty(openXmlElement);
      value.FieldData = GetFieldData(openXmlElement);
      value.CustomXmlRuby = GetCustomXmlRuby(openXmlElement);
      value.ChildSimpleFieldRuby = GetChildSimpleFieldRuby(openXmlElement);
      value.HyperlinkRuby = GetHyperlinkRuby(openXmlElement);
      value.Run = GetRun(openXmlElement);
      value.SdtRunRuby = GetSdtRunRuby(openXmlElement);
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
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SimpleFieldRuby? value)
    where OpenXmlElementType : SimpleFieldRuby, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetInstruction(openXmlElement, value?.Instruction);
      SetFieldLock(openXmlElement, value?.FieldLock);
      SetDirty(openXmlElement, value?.Dirty);
      SetFieldData(openXmlElement, value?.FieldData);
      SetCustomXmlRuby(openXmlElement, value?.CustomXmlRuby);
      SetChildSimpleFieldRuby(openXmlElement, value?.ChildSimpleFieldRuby);
      SetHyperlinkRuby(openXmlElement, value?.HyperlinkRuby);
      SetRun(openXmlElement, value?.Run);
      SetSdtRunRuby(openXmlElement, value?.SdtRunRuby);
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
      return openXmlElement;
    }
    return default;
  }
}