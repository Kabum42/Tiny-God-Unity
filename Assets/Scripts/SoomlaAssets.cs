using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Soomla.Store;

/// <summary>
/// This class defines our game's economy, which includes virtual goods, virtual currencies
/// and currency packs, virtual categories
/// </summary>
public class SoomlaAssets : IStoreAssets {
	
	/** Static Final Members **/
	
	
	
	public const string GEMS_1_ITEM_ID = "gems_1";
	public const string GEMS_1_PRODUCT_ID = "gems_1";
	
	public const string GEMS_2_ITEM_ID = "gems_2";
	public const string GEMS_2_PRODUCT_ID = "gems_2";
	
	
	
	/** Virtual Currencies **/
	
	
	/** Virtual Currency Packs **/
	
	
	/** Virtual Goods **/
	
	public static VirtualGood GEMS_1 = new SingleUseVG(
		"1 Gem",					//name
		"1 gem package",				//description
		GEMS_1_ITEM_ID,				//item id
		new PurchaseWithMarket(GEMS_1_PRODUCT_ID, 0.5)				//the way this virtual good is purchased
	);
	
	public static VirtualGood GEMS_2 = new SingleUseVG(
		"2 Gem Bag",					//name
		"2 gems package",				//description
		GEMS_2_ITEM_ID,				//item id
		new PurchaseWithMarket(GEMS_2_PRODUCT_ID, 0.84)				//the way this virtual good is purchased
	);
	
	
	/** Virtual Categories **/
	// The muffin rush theme doesn't support categories, so we just put everything under a general category.
	public static VirtualCategory GENERAL_CATEGORY = new VirtualCategory(
		"General", new List<string>(new string[] {GEMS_1_ITEM_ID, GEMS_2_ITEM_ID})
	);
	
	/// <summary>
	/// see parent.
	/// </summary>
	public int GetVersion() {
		return 0;
	}
	
	/// <summary>
	/// see parent.
	/// </summary>
	public VirtualCurrency[] GetCurrencies() {
		return new VirtualCurrency[]{};
	}
	
	/// <summary>
	/// see parent.
	/// </summary>
	public VirtualCurrencyPack[] GetCurrencyPacks() {
		return new VirtualCurrencyPack[]{};
	}
	
	/// <summary>
	/// see parent.
	/// </summary>
	public VirtualGood[] GetGoods() {
		return new VirtualGood[]{GEMS_1, GEMS_2};
	}
	
	/// <summary>
	/// see parent.
	/// </summary>
	public VirtualCategory[] GetCategories() {
		return new VirtualCategory[]{GENERAL_CATEGORY};
	}
	
}
