using System;

namespace DocumentModel.Attributes
{
  internal interface IConstraintAttribute
  {
    Type ConstraintType { get; }

    bool MinOccursIsNonZero { get; }

    bool MaxOccursGreatThanOne { get; }
  }
}