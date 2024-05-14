# DA.Systems.Cube.Norsk.Model.ShipmentBookingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pieces** | [**List&lt;Piece&gt;**](Piece.md) |  | 
**ReadyByDate** | **DateTimeOffset** | DateTime provided must included the Time and be in GMT format. | 
**Hawb** | **string** | The Hawb (House Airway Bill) is your own unique reference number for the shipment, for example it could be the order reference. | 
**Description** | **string** |  | [optional] 
**Value** | **double** | Total value of the shipment (ex. VAT) | [optional] 
**Currency** | **string** | Currency of the shipment value as a three letter ISO code.  If left unspecified then GBP will be used. | [optional] 
**NonDox** | **bool** | Uses to indicate of the shipment is documents or non-documents. | [optional] 
**DDP** | **bool** |  | [optional] 
**Pallet** | **bool** |  | [optional] 
**Invoice** | **string** | Optional - Base64 string can be provided to use PLT services with DHL for select countries. | [optional] 
**Requestor** | [**Requester**](Requester.md) |  | [optional] 
**Consignee** | [**Address**](Address.md) |  | 
**Collection** | [**CollectionAddress**](CollectionAddress.md) |  | [optional] 
**Shipper** | [**ShipperAddress**](ShipperAddress.md) |  | [optional] 
**Service** | [**Service**](Service.md) |  | 
**Specials** | [**Specials**](Specials.md) |  | [optional] 
**Picking** | [**Picking**](Picking.md) |  | [optional] 
**LabelFormat** | **LabelFormat** |  | [optional] 
**Site** | [**SiteDetails**](SiteDetails.md) |  | [optional] 
**ExportCustoms** | [**ExportCustoms**](ExportCustoms.md) |  | [optional] 
**CustomDeclarations** | [**Declarations**](Declarations.md) |  | [optional] 
**LabelSize** | **LabelSize** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

