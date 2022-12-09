//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from fbr2.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="fbr2Parser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface Ifbr2Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.fbr2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFbr2([NotNull] fbr2Parser.Fbr2Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.standardMessageIdentification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStandardMessageIdentification([NotNull] fbr2Parser.StandardMessageIdentificationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.flightInformation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFlightInformation([NotNull] fbr2Parser.FlightInformationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.requestReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRequestReference([NotNull] fbr2Parser.RequestReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.flightIdentification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFlightIdentification([NotNull] fbr2Parser.FlightIdentificationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.requestingOfficeMessageAddress"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRequestingOfficeMessageAddress([NotNull] fbr2Parser.RequestingOfficeMessageAddressContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.rofr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRofr([NotNull] fbr2Parser.RofrContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.requestingOfficeFileReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRequestingOfficeFileReference([NotNull] fbr2Parser.RequestingOfficeFileReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.requestingParticipantIdentification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRequestingParticipantIdentification([NotNull] fbr2Parser.RequestingParticipantIdentificationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.standardMessageIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStandardMessageIdentifier([NotNull] fbr2Parser.StandardMessageIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.messageTypeVersionNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMessageTypeVersionNumber([NotNull] fbr2Parser.MessageTypeVersionNumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.lineIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineIdentifier([NotNull] fbr2Parser.LineIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.carrierCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCarrierCode([NotNull] fbr2Parser.CarrierCodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.flightNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFlightNumber([NotNull] fbr2Parser.FlightNumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.dayOfScheduledDeparture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDayOfScheduledDeparture([NotNull] fbr2Parser.DayOfScheduledDepartureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.monthOfScheduledDeparture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMonthOfScheduledDeparture([NotNull] fbr2Parser.MonthOfScheduledDepartureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.airportCodeOfLoading"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAirportCodeOfLoading([NotNull] fbr2Parser.AirportCodeOfLoadingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.airportCodeOfUnloading"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAirportCodeOfUnloading([NotNull] fbr2Parser.AirportCodeOfUnloadingContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.airportCityCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAirportCityCode([NotNull] fbr2Parser.AirportCityCodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.officeFunctionDesignator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOfficeFunctionDesignator([NotNull] fbr2Parser.OfficeFunctionDesignatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.companyDesignator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompanyDesignator([NotNull] fbr2Parser.CompanyDesignatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.fileReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFileReference([NotNull] fbr2Parser.FileReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.participantIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParticipantIdentifier([NotNull] fbr2Parser.ParticipantIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fbr2Parser.participantCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParticipantCode([NotNull] fbr2Parser.ParticipantCodeContext context);
}
