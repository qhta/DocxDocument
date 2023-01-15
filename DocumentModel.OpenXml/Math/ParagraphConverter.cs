using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using BookmarkStart = DocumentModel.Wordprocessing.BookmarkStart;
using DeletedRun = DocumentModel.Wordprocessing.DeletedRun;
using InsertedRun = DocumentModel.Wordprocessing.InsertedRun;
using MarkupRangeType = DocumentModel.Wordprocessing.MarkupRangeType;
using MarkupType = DocumentModel.Wordprocessing.MarkupType;
using MoveBookmarkType = DocumentModel.Wordprocessing.MoveBookmarkType;
using MoveFromRun = DocumentModel.Wordprocessing.MoveFromRun;
using MoveToRun = DocumentModel.Wordprocessing.MoveToRun;
using OfficeMath = DocumentModel.Math.OfficeMath;
using Paragraph = DocumentFormat.OpenXml.Math.Paragraph;
using ParagraphProperties = DocumentModel.Math.ParagraphProperties;
using PermEnd = DocumentModel.Wordprocessing.PermEnd;
using PermStart = DocumentModel.Wordprocessing.PermStart;
using ProofError = DocumentModel.Wordprocessing.ProofError;
using Run = DocumentModel.Math.Run;
using RunConflictDeletion = DocumentModel.Wordprocessing.RunConflictDeletion;
using RunConflictInsertion = DocumentModel.Wordprocessing.RunConflictInsertion;
using TrackChangeType = DocumentModel.Wordprocessing.TrackChangeType;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public static class ParagraphConverter
{
  /// <summary>
  ///   Office Math Paragraph Properties.
  /// </summary>
  public static ParagraphProperties? GetParagraphProperties(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ParagraphProperties>();
    if (itemElement != null)
      return ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphProperties(Paragraph? openXmlElement, ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OfficeMath? GetOfficeMath(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
    if (itemElement != null)
      return OfficeMathConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeMath(Paragraph? openXmlElement, OfficeMath? value)
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

  public static Run? GetRun(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
    if (itemElement != null)
      return RunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRun(Paragraph? openXmlElement, Run? value)
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

  public static ProofError? GetProofError(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetProofError(Paragraph? openXmlElement, ProofError? value)
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

  public static PermStart? GetPermStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return PermStartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPermStart(Paragraph? openXmlElement, PermStart? value)
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

  public static PermEnd? GetPermEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return PermEndConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPermEnd(Paragraph? openXmlElement, PermEnd? value)
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

  public static BookmarkStart? GetBookmarkStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBookmarkStart(Paragraph? openXmlElement, BookmarkStart? value)
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

  public static MarkupRangeType? GetBookmarkEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BookmarkEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBookmarkEnd(Paragraph? openXmlElement, MarkupRangeType? value)
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

  public static MarkupRangeType? GetCommentRangeStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CommentRangeStart>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentRangeStart(Paragraph? openXmlElement, MarkupRangeType? value)
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

  public static MarkupRangeType? GetCommentRangeEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CommentRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentRangeEnd(Paragraph? openXmlElement, MarkupRangeType? value)
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

  public static MoveBookmarkType? GetMoveFromRangeStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveFromRangeStart>();
    if (itemElement != null)
      return MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRangeStart(Paragraph? openXmlElement, MoveBookmarkType? value)
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

  public static MarkupRangeType? GetMoveFromRangeEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveFromRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRangeEnd(Paragraph? openXmlElement, MarkupRangeType? value)
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

  public static MoveBookmarkType? GetMoveToRangeStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveToRangeStart>();
    if (itemElement != null)
      return MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRangeStart(Paragraph? openXmlElement, MoveBookmarkType? value)
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

  public static MarkupRangeType? GetMoveToRangeEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MoveToRangeEnd>();
    if (itemElement != null)
      return MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRangeEnd(Paragraph? openXmlElement, MarkupRangeType? value)
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

  public static TrackChangeType? GetCustomXmlInsRangeStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlInsRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlInsRangeStart(Paragraph? openXmlElement, TrackChangeType? value)
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

  public static MarkupType? GetCustomXmlInsRangeEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlInsRangeEnd(Paragraph? openXmlElement, MarkupType? value)
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

  public static TrackChangeType? GetCustomXmlDelRangeStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlDelRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlDelRangeStart(Paragraph? openXmlElement, TrackChangeType? value)
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

  public static MarkupType? GetCustomXmlDelRangeEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlDelRangeEnd(Paragraph? openXmlElement, MarkupType? value)
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

  public static TrackChangeType? GetCustomXmlMoveFromRangeStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveFromRangeStart(Paragraph? openXmlElement, TrackChangeType? value)
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

  public static MarkupType? GetCustomXmlMoveFromRangeEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveFromRangeEnd(Paragraph? openXmlElement, MarkupType? value)
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

  public static TrackChangeType? GetCustomXmlMoveToRangeStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveToRangeStart(Paragraph? openXmlElement, TrackChangeType? value)
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

  public static MarkupType? GetCustomXmlMoveToRangeEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlMoveToRangeEnd(Paragraph? openXmlElement, MarkupType? value)
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

  public static TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictInsertionRangeStart(Paragraph? openXmlElement, TrackChangeType2? value)
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

  public static MarkupType2? GetCustomXmlConflictInsertionRangeEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictInsertionRangeEnd(Paragraph? openXmlElement, MarkupType2? value)
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

  public static TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictDeletionRangeStart(Paragraph? openXmlElement, TrackChangeType2? value)
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

  public static MarkupType2? GetCustomXmlConflictDeletionRangeEnd(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomXmlConflictDeletionRangeEnd(Paragraph? openXmlElement, MarkupType2? value)
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

  public static InsertedRun? GetInsertedRun(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      return InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsertedRun(Paragraph? openXmlElement, InsertedRun? value)
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

  public static DeletedRun? GetDeletedRun(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      return DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeletedRun(Paragraph? openXmlElement, DeletedRun? value)
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

  public static MoveFromRun? GetMoveFromRun(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      return MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromRun(Paragraph? openXmlElement, MoveFromRun? value)
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

  public static MoveToRun? GetMoveToRun(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      return MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToRun(Paragraph? openXmlElement, MoveToRun? value)
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

  public static RunConflictInsertion? GetRunConflictInsertion(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      return RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunConflictInsertion(Paragraph? openXmlElement, RunConflictInsertion? value)
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

  public static RunConflictDeletion? GetRunConflictDeletion(Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      return RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunConflictDeletion(Paragraph? openXmlElement, RunConflictDeletion? value)
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

  public static DocumentModel.Math.Paragraph? CreateModelElement(Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Paragraph();
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      value.OfficeMath = GetOfficeMath(openXmlElement);
      value.Run = GetRun(openXmlElement);
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
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Paragraph? value)
    where OpenXmlElementType : Paragraph, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
      SetOfficeMath(openXmlElement, value?.OfficeMath);
      SetRun(openXmlElement, value?.Run);
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
      return openXmlElement;
    }
    return default;
  }
}