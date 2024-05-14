# DA.Systems.Cube.Norsk.Model.QuoteRequestModel
Represents a model for a quote request in the shipment process. This model includes detailed information   about the shipping date, destination, collection source, value of the shipment, its pieces, and any applicable extra charges.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShippingDate** | **DateTimeOffset** | The expected shipping date. More accurate prices are provided if the date is closer to the actual shipping date. | 
**Zipcode** | **string** | The ZIP code of the destination, if applicable. | [optional] 
**Town** | **string** | The town of the destination. | [optional] 
**CountryCode** | **string** | The country code of the destination. | 
**Collection** | [**From**](From.md) |  | [optional] 
**Dutiable** | [**Dutiable**](Dutiable.md) |  | [optional] 
**AdditionalServiceOptions** | [**ServiceOptions**](ServiceOptions.md) |  | [optional] 
**Pieces** | [**List&lt;QuoteRequestPiece&gt;**](QuoteRequestPiece.md) | A list describing all the pieces in the shipment. | 
**Specials** | [**List&lt;QuoteSpecials&gt;**](QuoteSpecials.md) | A list of additional charges to apply to the quote, e.g., for Delivery Duty Paid (DDP). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

