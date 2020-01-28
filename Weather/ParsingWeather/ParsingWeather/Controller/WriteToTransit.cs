using System;

public class WriteToTransit
{
	public WriteToTransit(WebData data)
	{
        TransitData.webName = data.getName();
        //TransitData.cityName = data.getKey();
        TransitData.key = data.getKey();
        TransitData.addLink = data.getAddLink();
        TransitData.listNameOutputParam = data.getListNameParam();
        TransitData.dictRequestParam = data.getDictParam();
    }
}
