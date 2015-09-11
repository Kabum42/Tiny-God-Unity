using UnityEngine;
using System.Collections;

public static class Lang {

	public static bool started = false;
	
	public static int CURRENT_VALUE = 0;
	
	public static int ENGLISH_VALUE = 0;
	public static int SPANISH_VALUE = 1;
	public static int CATALAN_VALUE = 2;
	public static int ITALIAN_VALUE = 3;
	public static int FRENCH_VALUE = 4;
	public static int ROMANIAN_VALUE = 5;
	public static int GERMAN_VALUE = 6;
	public static int RUSSIAN_VALUE = 7;
	
	public static string[][]LANGUAGES = new string[10][];

	public static int amount_words = 300;
	
	public static string[]ENGLISH_WORDS = new string[amount_words];
	public static string[]SPANISH_WORDS = new string[amount_words];
	public static string[]CATALAN_WORDS = new string[amount_words];
	public static string[]ITALIAN_WORDS = new string[amount_words];
	public static string[]FRENCH_WORDS = new string[amount_words];
	public static string[]ROMANIAN_WORDS = new string[amount_words];
	public static string[]GERMAN_WORDS = new string[amount_words];
	public static string[]RUSSIAN_WORDS = new string[amount_words];
	
	// MISCELLANEOUS
	public static int TRANSLATOR_MALE = 				0;
	public static int TRANSLATOR_FEMALE = 				1;
	public static int TRANSLATORS = 					2;
	public static int BUILDING = 						3;
	public static int BUILDINGS = 						4;
	public static int UPGRADE = 						5;
	public static int UPGRADES = 						6;
	public static int ACHIEVEMENT = 					7;
	public static int ACHIEVEMENTS = 					8;
	public static int LOVE_SINCE_BEGINNING_GAME = 		9;
	public static int LOVE_SINCE_BEGINNING_TIMES = 		10;
	public static int PRODUCTION_MULTIPLIER = 			11;
	public static int CURRENT_LOVE = 					12;
	public static int LOVE_PER_CLICK = 					13;
	public static int CRITICAL_CLICK = 					14;
	public static int CRITICAL_CLICK_CHANCE = 			15;
	public static int NUMBER_OF_CLICKS = 				16;
	public static int NUMBER_OF_MIRACLES = 				17;
	public static int GAIN_BASE_LOVE = 					18;
	public static int PRODUCE_TWICE_LOVE = 				19;
	
	// SERVANT
	public static int SERVANT_NAME = 					20;
	public static int SERVANT_DESCRIPTION = 			21;
	public static int SERVANT_UPGRADE_1 = 				22;
	public static int SERVANT_UPGRADE_1_JOKE =  		23;
	public static int SERVANT_UPGRADE_2 = 				24;
	public static int SERVANT_UPGRADE_2_JOKE =  		25;
	public static int SERVANT_UPGRADE_3 = 				26;
	public static int SERVANT_UPGRADE_3_JOKE =  		27;
	public static int SERVANT_UPGRADE_4 = 				28;
	public static int SERVANT_UPGRADE_4_JOKE =  		29;
	public static int SERVANT_UPGRADE_5 = 				30;
	public static int SERVANT_UPGRADE_5_JOKE =  		31;
	public static int SERVANT_UPGRADE_6 = 				32;
	public static int SERVANT_UPGRADE_6_JOKE =  		33;
	public static int SERVANT_UPGRADE_7 = 				34;
	public static int SERVANT_UPGRADE_7_JOKE =  		35;
	public static int SERVANT_UPGRADE_8 = 				36;
	public static int SERVANT_UPGRADE_8_JOKE =  		37;
	public static int SERVANT_UPGRADE_9 = 				38;
	public static int SERVANT_UPGRADE_9_JOKE =  		39;
	public static int SERVANT_UPGRADE_10 = 				40;
	public static int SERVANT_UPGRADE_10_JOKE = 		41;
	
	// HUMAN
	public static int HUMAN_NAME = 						42;
	public static int HUMAN_DESCRIPTION = 				43;
	public static int HUMAN_UPGRADE_1 = 				44;
	public static int HUMAN_UPGRADE_1_JOKE =  			45;
	public static int HUMAN_UPGRADE_2 = 				46;
	public static int HUMAN_UPGRADE_2_JOKE =  			47;
	public static int HUMAN_UPGRADE_3 = 				48;
	public static int HUMAN_UPGRADE_3_JOKE =  			49;
	public static int HUMAN_UPGRADE_4 = 				50;
	public static int HUMAN_UPGRADE_4_JOKE =  			51;
	public static int HUMAN_UPGRADE_5 = 				52;
	public static int HUMAN_UPGRADE_5_JOKE =  			53;
	public static int HUMAN_UPGRADE_6 = 				54;
	public static int HUMAN_UPGRADE_6_JOKE =  			55;
	public static int HUMAN_UPGRADE_7 = 				56;
	public static int HUMAN_UPGRADE_7_JOKE =  			57;
	public static int HUMAN_UPGRADE_8 = 				58;
	public static int HUMAN_UPGRADE_8_JOKE =  			59;
	public static int HUMAN_UPGRADE_9 = 				60;
	public static int HUMAN_UPGRADE_9_JOKE = 			61;
	public static int HUMAN_UPGRADE_10 = 				62;
	public static int HUMAN_UPGRADE_10_JOKE =  			63;
	
	// SPECIAL_HUMANS
	public static int SPECIAL_HUMAN_1 = 				64;
	public static int SPECIAL_HUMAN_1_JOKE =  			65;
	public static int SPECIAL_HUMAN_2 = 				66;
	public static int SPECIAL_HUMAN_2_JOKE =  			67;
	public static int SPECIAL_HUMAN_3 = 				68;
	public static int SPECIAL_HUMAN_3_JOKE =  			69;
	public static int SPECIAL_HUMAN_4 = 				70;
	public static int SPECIAL_HUMAN_4_JOKE =  			71;
	public static int SPECIAL_HUMAN_5 = 				72;
	public static int SPECIAL_HUMAN_5_JOKE =  			73;
	public static int SPECIAL_HUMAN_6 = 				74;
	public static int SPECIAL_HUMAN_6_JOKE =  			75;
	public static int SPECIAL_HUMAN_7 = 				76;
	public static int SPECIAL_HUMAN_7_JOKE =  			77;
	public static int SPECIAL_HUMAN_8 = 				78;
	public static int SPECIAL_HUMAN_8_JOKE =  			79;
	public static int SPECIAL_HUMAN_9 = 				80;
	public static int SPECIAL_HUMAN_9_JOKE =  			81;
	public static int SPECIAL_HUMAN_10 = 				82;
	public static int SPECIAL_HUMAN_10_JOKE =  			83;
	
	// PROPHET
	public static int PROPHET_NAME = 					84;
	public static int PROPHET_DESCRIPTION = 			85;
	public static int PROPHET_UPGRADE_1 = 				86;
	public static int PROPHET_UPGRADE_1_JOKE =  		87;
	public static int PROPHET_UPGRADE_2 = 				88;
	public static int PROPHET_UPGRADE_2_JOKE =  		89;
	public static int PROPHET_UPGRADE_3 = 				90;
	public static int PROPHET_UPGRADE_3_JOKE =  		91;
	public static int PROPHET_UPGRADE_4 = 				92;
	public static int PROPHET_UPGRADE_4_JOKE =  		93;
	public static int PROPHET_UPGRADE_5 = 				94;
	public static int PROPHET_UPGRADE_5_JOKE =  		95;
	public static int PROPHET_UPGRADE_6 = 				96;
	public static int PROPHET_UPGRADE_6_JOKE =  		97;
	public static int PROPHET_UPGRADE_7 = 				98;
	public static int PROPHET_UPGRADE_7_JOKE =  		99;
	public static int PROPHET_UPGRADE_8 = 				100;
	public static int PROPHET_UPGRADE_8_JOKE =  		101;
	public static int PROPHET_UPGRADE_9 = 				102;
	public static int PROPHET_UPGRADE_9_JOKE = 			103;
	public static int PROPHET_UPGRADE_10 = 				104;
	public static int PROPHET_UPGRADE_10_JOKE =  		105;
	
	// TEMPLE
	public static int TEMPLE_NAME = 					106;
	public static int TEMPLE_DESCRIPTION = 				107;
	public static int TEMPLE_UPGRADE_1 = 				108;
	public static int TEMPLE_UPGRADE_1_JOKE =  			109;
	public static int TEMPLE_UPGRADE_2 = 				110;
	public static int TEMPLE_UPGRADE_2_JOKE =  			111;
	public static int TEMPLE_UPGRADE_3 = 				112;
	public static int TEMPLE_UPGRADE_3_JOKE =  			113;
	public static int TEMPLE_UPGRADE_4 = 				114;
	public static int TEMPLE_UPGRADE_4_JOKE =  			115;
	public static int TEMPLE_UPGRADE_5 = 				116;
	public static int TEMPLE_UPGRADE_5_JOKE =  			117;
	public static int TEMPLE_UPGRADE_6 = 				118;
	public static int TEMPLE_UPGRADE_6_JOKE =  			119;
	public static int TEMPLE_UPGRADE_7 = 				120;
	public static int TEMPLE_UPGRADE_7_JOKE =  			121;
	public static int TEMPLE_UPGRADE_8 = 				122;
	public static int TEMPLE_UPGRADE_8_JOKE =  			123;
	public static int TEMPLE_UPGRADE_9 = 				124;
	public static int TEMPLE_UPGRADE_9_JOKE = 			125;
	public static int TEMPLE_UPGRADE_10 = 				126;
	public static int TEMPLE_UPGRADE_10_JOKE =  		127;
	
	// SHIP
	public static int SHIP_NAME = 						128;
	public static int SHIP_DESCRIPTION = 				129;
	public static int SHIP_UPGRADE_1 = 					130;
	public static int SHIP_UPGRADE_1_JOKE =  			131;
	public static int SHIP_UPGRADE_2 = 					132;
	public static int SHIP_UPGRADE_2_JOKE =  			133;
	public static int SHIP_UPGRADE_3 = 					134;
	public static int SHIP_UPGRADE_3_JOKE =  			135;
	public static int SHIP_UPGRADE_4 = 					136;
	public static int SHIP_UPGRADE_4_JOKE =  			137;
	public static int SHIP_UPGRADE_5 = 					138;
	public static int SHIP_UPGRADE_5_JOKE =  			139;
	public static int SHIP_UPGRADE_6 = 					140;
	public static int SHIP_UPGRADE_6_JOKE =  			141;
	public static int SHIP_UPGRADE_7 = 					142;
	public static int SHIP_UPGRADE_7_JOKE =  			143;
	public static int SHIP_UPGRADE_8 = 					144;
	public static int SHIP_UPGRADE_8_JOKE =  			145;
	public static int SHIP_UPGRADE_9 = 					146;
	public static int SHIP_UPGRADE_9_JOKE = 			147;
	public static int SHIP_UPGRADE_10 = 				148;
	public static int SHIP_UPGRADE_10_JOKE =  			149;
	
	// FACTORY
	public static int FACTORY_NAME = 					150;
	public static int FACTORY_DESCRIPTION = 			151;
	public static int FACTORY_UPGRADE_1 = 				152;
	public static int FACTORY_UPGRADE_1_JOKE =  		153;
	public static int FACTORY_UPGRADE_2 = 				154;
	public static int FACTORY_UPGRADE_2_JOKE =  		155;
	public static int FACTORY_UPGRADE_3 = 				156;
	public static int FACTORY_UPGRADE_3_JOKE =  		157;
	public static int FACTORY_UPGRADE_4 = 				158;
	public static int FACTORY_UPGRADE_4_JOKE =  		159;
	public static int FACTORY_UPGRADE_5 = 				160;
	public static int FACTORY_UPGRADE_5_JOKE =  		161;
	public static int FACTORY_UPGRADE_6 = 				162;
	public static int FACTORY_UPGRADE_6_JOKE =  		163;
	public static int FACTORY_UPGRADE_7 = 				164;
	public static int FACTORY_UPGRADE_7_JOKE =  		165;
	public static int FACTORY_UPGRADE_8 = 				166;
	public static int FACTORY_UPGRADE_8_JOKE =  		167;
	public static int FACTORY_UPGRADE_9 = 				168;
	public static int FACTORY_UPGRADE_9_JOKE = 			169;
	public static int FACTORY_UPGRADE_10 = 				170;
	public static int FACTORY_UPGRADE_10_JOKE =  		171;
	
	// LABORATORY
	public static int LABORATORY_NAME = 				172;
	public static int LABORATORY_DESCRIPTION = 			173;
	public static int LABORATORY_UPGRADE_1 = 			174;
	public static int LABORATORY_UPGRADE_1_JOKE =  		175;
	public static int LABORATORY_UPGRADE_2 = 			176;
	public static int LABORATORY_UPGRADE_2_JOKE =  		177;
	public static int LABORATORY_UPGRADE_3 = 			178;
	public static int LABORATORY_UPGRADE_3_JOKE =  		179;
	public static int LABORATORY_UPGRADE_4 = 			180;
	public static int LABORATORY_UPGRADE_4_JOKE =  		181;
	public static int LABORATORY_UPGRADE_5 = 			182;
	public static int LABORATORY_UPGRADE_5_JOKE =  		183;
	public static int LABORATORY_UPGRADE_6 = 			184;
	public static int LABORATORY_UPGRADE_6_JOKE =  		185;
	public static int LABORATORY_UPGRADE_7 = 			186;
	public static int LABORATORY_UPGRADE_7_JOKE =  		187;
	public static int LABORATORY_UPGRADE_8 = 			188;
	public static int LABORATORY_UPGRADE_8_JOKE =  		189;
	public static int LABORATORY_UPGRADE_9 = 			190;
	public static int LABORATORY_UPGRADE_9_JOKE = 		191;
	public static int LABORATORY_UPGRADE_10 = 			192;
	public static int LABORATORY_UPGRADE_10_JOKE =  	193;
	
	// SHOP
	public static int SHOP_NAME = 						194;
	public static int SHOP_DESCRIPTION = 				195;
	public static int SHOP_UPGRADE_1 = 					196;
	public static int SHOP_UPGRADE_1_JOKE =  			197;
	public static int SHOP_UPGRADE_2 = 					198;
	public static int SHOP_UPGRADE_2_JOKE =  			199;
	public static int SHOP_UPGRADE_3 = 					200;
	public static int SHOP_UPGRADE_3_JOKE =  			201;
	public static int SHOP_UPGRADE_4 = 					202;
	public static int SHOP_UPGRADE_4_JOKE =  			203;
	public static int SHOP_UPGRADE_5 = 					204;
	public static int SHOP_UPGRADE_5_JOKE =  			205;
	public static int SHOP_UPGRADE_6 = 					206;
	public static int SHOP_UPGRADE_6_JOKE =  			207;
	public static int SHOP_UPGRADE_7 = 					208;
	public static int SHOP_UPGRADE_7_JOKE =  			209;
	public static int SHOP_UPGRADE_8 = 					210;
	public static int SHOP_UPGRADE_8_JOKE =  			211;
	public static int SHOP_UPGRADE_9 = 					212;
	public static int SHOP_UPGRADE_9_JOKE = 			213;
	public static int SHOP_UPGRADE_10 = 				214;
	public static int SHOP_UPGRADE_10_JOKE =  			215;
	
	// SPACESHIP
	public static int SPACESHIP_NAME = 					216;
	public static int SPACESHIP_DESCRIPTION = 			217;
	public static int SPACESHIP_UPGRADE_1 = 			218;
	public static int SPACESHIP_UPGRADE_1_JOKE =  		219;
	public static int SPACESHIP_UPGRADE_2 = 			220;
	public static int SPACESHIP_UPGRADE_2_JOKE =  		221;
	public static int SPACESHIP_UPGRADE_3 = 			222;
	public static int SPACESHIP_UPGRADE_3_JOKE =  		223;
	public static int SPACESHIP_UPGRADE_4 = 			224;
	public static int SPACESHIP_UPGRADE_4_JOKE =  		225;
	public static int SPACESHIP_UPGRADE_5 = 			226;
	public static int SPACESHIP_UPGRADE_5_JOKE =  		227;
	public static int SPACESHIP_UPGRADE_6 = 			228;
	public static int SPACESHIP_UPGRADE_6_JOKE =  		229;
	public static int SPACESHIP_UPGRADE_7 = 			230;
	public static int SPACESHIP_UPGRADE_7_JOKE =  		231;
	public static int SPACESHIP_UPGRADE_8 = 			232;
	public static int SPACESHIP_UPGRADE_8_JOKE =  		233;
	public static int SPACESHIP_UPGRADE_9 = 			234;
	public static int SPACESHIP_UPGRADE_9_JOKE = 		235;
	public static int SPACESHIP_UPGRADE_10 = 			236;
	public static int SPACESHIP_UPGRADE_10_JOKE =  		237;
	
	// MORE MISCELLANEOUS
	public static int LANGUAGE_WORD =  					238;
	public static int AVAILABLE_WORD =  				239;
	public static int BOUGHT_WORD =  					240;
	public static int SAVE_WORD =  						241;
	public static int STATISTICS_WORD =  				242;
	public static int CREDITS_WORD =  					243;
	public static int LOVE_WORD =  						244;
	public static int LOVE_PER_SECOND_WORD =  			245;
	public static int CLICKS_WORD =  					246;
	public static int LOVE_PER_CLICK_WORD =  			247;
	public static int CRITICAL_CLICK_MULTIPLIER_WORD =  248;
	public static int TRANSLATORS_WORD =  				249;
	public static int FRENCH_TRANSLATOR_WORD =  		250;
	public static int GERMAN_TRANSLATOR_WORD =  		251;
	public static int ITALIAN_TRANSLATOR_WORD =  		252;
	public static int RUSSIAN_TRANSLATOR_WORD =  		253;
	public static int CATALAN_TRANSLATOR_WORD =  		254;
	public static int ROMANIAN_TRANSLATOR_WORD =  		255;
	public static int COST_WORD =  						256;
	public static int IT_PRODUCES_WORD =  				257;
	
	// YAHVY MESSAGES
	public static int MESSAGE_AMOUNT = 18;
	
	public static int[]MESSAGES = new int[MESSAGE_AMOUNT];
	
	public static int MESSAGE_01 =  					258;
	public static int MESSAGE_02 =  					259;
	public static int MESSAGE_03 =  					260;
	public static int MESSAGE_04 =  					261;
	public static int MESSAGE_05 =  					262;
	public static int MESSAGE_06 =  					263;
	public static int MESSAGE_07 =  					264;
	public static int MESSAGE_08 =  					265;
	public static int MESSAGE_09 =  					266;
	public static int MESSAGE_10 =  					267;
	public static int MESSAGE_11 =  					268;
	public static int MESSAGE_12 =  					269;
	public static int MESSAGE_13 =  					270;
	public static int MESSAGE_14 =  					271;
	public static int MESSAGE_15 =  					272;
	public static int MESSAGE_16 =  					273;
	public static int MESSAGE_17 =  					274;
	public static int MESSAGE_18 =  					275;

	// Use this for initialization
	public static void Start () {
	
		started = true;
		
		MESSAGES[0] = MESSAGE_01;
		MESSAGES[1] = MESSAGE_02;
		MESSAGES[2] = MESSAGE_03;
		MESSAGES[3] = MESSAGE_04;
		MESSAGES[4] = MESSAGE_05;
		MESSAGES[5] = MESSAGE_06;
		MESSAGES[6] = MESSAGE_07;
		MESSAGES[7] = MESSAGE_08;
		MESSAGES[8] = MESSAGE_09;
		MESSAGES[9] = MESSAGE_10;
		MESSAGES[10] = MESSAGE_11;
		MESSAGES[11] = MESSAGE_12;
		MESSAGES[12] = MESSAGE_13;
		MESSAGES[13] = MESSAGE_14;
		MESSAGES[14] = MESSAGE_15;
		MESSAGES[15] = MESSAGE_16;
		MESSAGES[16] = MESSAGE_17;
		MESSAGES[17] = MESSAGE_18;

		
		LANGUAGES[ENGLISH_VALUE] = ENGLISH_WORDS;
		LANGUAGES[SPANISH_VALUE] = SPANISH_WORDS;
		LANGUAGES[CATALAN_VALUE] = CATALAN_WORDS;
		LANGUAGES[ITALIAN_VALUE] = ITALIAN_WORDS;
		LANGUAGES[FRENCH_VALUE] = FRENCH_WORDS;
		LANGUAGES[ROMANIAN_VALUE] = ROMANIAN_WORDS;
		LANGUAGES[GERMAN_VALUE] = GERMAN_WORDS;
		LANGUAGES[RUSSIAN_VALUE] = RUSSIAN_WORDS;
		
		
		/**ENGLISH**/
		
		// MISCELLANEOUS
		ENGLISH_WORDS[TRANSLATOR_MALE] = "Translator";
		ENGLISH_WORDS[TRANSLATOR_FEMALE] = "Translator";
		ENGLISH_WORDS[TRANSLATORS] = "Translators";
		ENGLISH_WORDS[BUILDING] = "Building";
		ENGLISH_WORDS[BUILDINGS] = "Buildings";
		ENGLISH_WORDS[UPGRADE] = "Upgrade";
		ENGLISH_WORDS[UPGRADES] = "Upgrades";
		ENGLISH_WORDS[ACHIEVEMENT] = "Achievement";
		ENGLISH_WORDS[ACHIEVEMENTS] = "Achievements";
		ENGLISH_WORDS[LOVE_SINCE_BEGINNING_GAME] = "Love since beginning of this game";
		ENGLISH_WORDS[LOVE_SINCE_BEGINNING_TIMES] = "Love since beginning of times";
		ENGLISH_WORDS[PRODUCTION_MULTIPLIER] = "Production multiplier";
		ENGLISH_WORDS[CURRENT_LOVE] = "Current love";
		ENGLISH_WORDS[LOVE_PER_CLICK] = "Love per click";
		ENGLISH_WORDS[CRITICAL_CLICK] = "Critical click";
		ENGLISH_WORDS[CRITICAL_CLICK_CHANCE] = "Critical click chance";
		ENGLISH_WORDS[NUMBER_OF_CLICKS] = "Number of clicks";
		ENGLISH_WORDS[NUMBER_OF_MIRACLES] = "Number of miracles";
		ENGLISH_WORDS[GAIN_BASE_LOVE] = "X gain +Y base love per second";
		ENGLISH_WORDS[PRODUCE_TWICE_LOVE] = "X produce twice the love";
		
		// SERVANT
		ENGLISH_WORDS[SERVANT_NAME] = "Servant";
		ENGLISH_WORDS[SERVANT_DESCRIPTION] = "A loyal servant, it whispers nice things";
		ENGLISH_WORDS[SERVANT_UPGRADE_1] = "Duckface";
		ENGLISH_WORDS[SERVANT_UPGRADE_1_JOKE] = "Adorably unbearable";
		ENGLISH_WORDS[SERVANT_UPGRADE_2] = "Dental plan";
		ENGLISH_WORDS[SERVANT_UPGRADE_2_JOKE] = "Lisa needs braces";
		ENGLISH_WORDS[SERVANT_UPGRADE_3] = "Naughty whispers";
		ENGLISH_WORDS[SERVANT_UPGRADE_3_JOKE] = "Talk dirty to me";
		ENGLISH_WORDS[SERVANT_UPGRADE_4] = "Babylon curse";
		ENGLISH_WORDS[SERVANT_UPGRADE_4_JOKE] = "I taught them languages ​​I don't understand so I can ignore them";
		ENGLISH_WORDS[SERVANT_UPGRADE_5] = "Love, God & Rock and roll";
		ENGLISH_WORDS[SERVANT_UPGRADE_5_JOKE] = "The Holy Trinity";
		ENGLISH_WORDS[SERVANT_UPGRADE_6] = "Voices in your head";
		ENGLISH_WORDS[SERVANT_UPGRADE_6_JOKE] = "Are you talking to me?";
		ENGLISH_WORDS[SERVANT_UPGRADE_7] = "Awakening";
		ENGLISH_WORDS[SERVANT_UPGRADE_7_JOKE] = "Wake up, my children";
		//ENGLISH_WORDS[SERVANT_UPGRADE_8] = "Love, God & Rock and roll";
		//ENGLISH_WORDS[SERVANT_UPGRADE_8_JOKE] = "The Holy Trinity";
		//ENGLISH_WORDS[SERVANT_UPGRADE_9] = "Voices in your head";
		//ENGLISH_WORDS[SERVANT_UPGRADE_9_JOKE] = "Are you talking to me?";
		//ENGLISH_WORDS[SERVANT_UPGRADE_10] = "Awakening";
		//ENGLISH_WORDS[SERVANT_UPGRADE_10_JOKE] = "Wake up, my children";
		
		// HUMAN
		ENGLISH_WORDS[HUMAN_NAME] = "Human";
		ENGLISH_WORDS[HUMAN_DESCRIPTION] = "A human who doesn’t quite understand your wisdom, but prays to you anyway";
		ENGLISH_WORDS[HUMAN_UPGRADE_1] = "Narcissistic";
		ENGLISH_WORDS[HUMAN_UPGRADE_1_JOKE] = "In your own image and likeness";
		ENGLISH_WORDS[HUMAN_UPGRADE_2] = "Rib companion";
		ENGLISH_WORDS[HUMAN_UPGRADE_2_JOKE] = "It’s funnier to play with someone else";
		ENGLISH_WORDS[HUMAN_UPGRADE_3] = "Vegetal lingerie";
		ENGLISH_WORDS[HUMAN_UPGRADE_3_JOKE] = "Sexy and ecological";
		ENGLISH_WORDS[HUMAN_UPGRADE_4] = "Knowledge apple";
		ENGLISH_WORDS[HUMAN_UPGRADE_4_JOKE] = "Now I know your fantasies";
		ENGLISH_WORDS[HUMAN_UPGRADE_5] = "Pro-life fanatics";
		ENGLISH_WORDS[HUMAN_UPGRADE_5_JOKE] = "Every sperm is sacred";
		ENGLISH_WORDS[HUMAN_UPGRADE_6] = "Arrogant apes";
		ENGLISH_WORDS[HUMAN_UPGRADE_6_JOKE] = "No gods or kings, only man";
		ENGLISH_WORDS[HUMAN_UPGRADE_7] = "Soylent Green";
		ENGLISH_WORDS[HUMAN_UPGRADE_7_JOKE] = "100% recycled";
		//ENGLISH_WORDS[HUMAN_UPGRADE_8] = "Storks union";
		//ENGLISH_WORDS[HUMAN_UPGRADE_8_JOKE] = "It was necessary at this time";
		//ENGLISH_WORDS[HUMAN_UPGRADE_9] = "Arrogant apes";
		//ENGLISH_WORDS[HUMAN_UPGRADE_9_JOKE] = "No gods or kings, only man";
		//ENGLISH_WORDS[HUMAN_UPGRADE_10] = "Soylent Green";
		//ENGLISH_WORDS[HUMAN_UPGRADE_10_JOKE] = "100% recycled";
		
		// SPECIAL HUMANS
		ENGLISH_WORDS[SPECIAL_HUMAN_1] = "Zealot";
		ENGLISH_WORDS[SPECIAL_HUMAN_1_JOKE] = "God exists because that's what the book says, and the book is God’s word";
		ENGLISH_WORDS[SPECIAL_HUMAN_2] = "Crusader";
		ENGLISH_WORDS[SPECIAL_HUMAN_2_JOKE] = "That’s only a scratch, I still have another arm";
		ENGLISH_WORDS[SPECIAL_HUMAN_3] = "Slave driver";
		ENGLISH_WORDS[SPECIAL_HUMAN_3_JOKE] = "We give them permanent jobs and sometimes even food, they can’t complain";
		ENGLISH_WORDS[SPECIAL_HUMAN_4] = "Bourgeois";
		ENGLISH_WORDS[SPECIAL_HUMAN_4_JOKE] = "What's mine is mine and what’s yours will soon be mine";
		ENGLISH_WORDS[SPECIAL_HUMAN_5] = "Mad scientist";
		ENGLISH_WORDS[SPECIAL_HUMAN_5_JOKE] = "I call it the ‘L.A.S.E.R.’ Mwahahaha";
		ENGLISH_WORDS[SPECIAL_HUMAN_6] = "Televangelist";
		ENGLISH_WORDS[SPECIAL_HUMAN_6_JOKE] = "Hallelujah, brother, your bank transfer won’t be in vain";
		ENGLISH_WORDS[SPECIAL_HUMAN_7] = "Cyborg";
		ENGLISH_WORDS[SPECIAL_HUMAN_7_JOKE] = "I have... seen things you people wouldn't believe";
		
		// PROPHET
		ENGLISH_WORDS[PROPHET_NAME] = "Prophet";
		ENGLISH_WORDS[PROPHET_DESCRIPTION] = "A prophet is a human who understands even less, but thinks the exact opposite";
		ENGLISH_WORDS[PROPHET_UPGRADE_1] = "Fake beard";
		ENGLISH_WORDS[PROPHET_UPGRADE_1_JOKE] = "Essential for stoning";
		ENGLISH_WORDS[PROPHET_UPGRADE_2] = "The Flood";
		ENGLISH_WORDS[PROPHET_UPGRADE_2_JOKE] = "Save two of each kind: two brunettes, two redheads and two blondes";
		ENGLISH_WORDS[PROPHET_UPGRADE_3] = "Shooting star";
		ENGLISH_WORDS[PROPHET_UPGRADE_3_JOKE] = "The moment is coming";
		ENGLISH_WORDS[PROPHET_UPGRADE_4] = "Miraculous duplication";
		ENGLISH_WORDS[PROPHET_UPGRADE_4_JOKE] = "This is against thermodynam-SHUT UP!";
		ENGLISH_WORDS[PROPHET_UPGRADE_5] = "Resurrection";
		ENGLISH_WORDS[PROPHET_UPGRADE_5_JOKE] = "You may take a shower after three days being dead";
		ENGLISH_WORDS[PROPHET_UPGRADE_6] = "Holy book of Love";
		ENGLISH_WORDS[PROPHET_UPGRADE_6_JOKE] = "Wait, what are all those positions for?";
		ENGLISH_WORDS[PROPHET_UPGRADE_7] = "Lovelogy";
		ENGLISH_WORDS[PROPHET_UPGRADE_7_JOKE] = "All you need to know to avoid it";
		//ENGLISH_WORDS[PROPHET_UPGRADE_8] = "Holy book of Love";
		//ENGLISH_WORDS[PROPHET_UPGRADE_8_JOKE] = "Wait, what are all those positions for?";
		//ENGLISH_WORDS[PROPHET_UPGRADE_9] = "Lovelogy";
		//ENGLISH_WORDS[PROPHET_UPGRADE_9_JOKE] = "All you need to know to avoid it";
		//ENGLISH_WORDS[PROPHET_UPGRADE_10] = "Unfair competition";
		//ENGLISH_WORDS[PROPHET_UPGRADE_10_JOKE] = "If their god were real, wouldn’t he saved them?";
		
		// TEMPLE
		ENGLISH_WORDS[TEMPLE_NAME] = "Temple";
		ENGLISH_WORDS[TEMPLE_DESCRIPTION] = "A temple in the name of love, more or less";
		ENGLISH_WORDS[TEMPLE_UPGRADE_1] = "Generous almsgiving";
		ENGLISH_WORDS[TEMPLE_UPGRADE_1_JOKE] = "It never has been easier to earn a living";
		ENGLISH_WORDS[TEMPLE_UPGRADE_2] = "Repulsive relic";
		ENGLISH_WORDS[TEMPLE_UPGRADE_2_JOKE] = "I hope that's a wrinkled thumb...";
		ENGLISH_WORDS[TEMPLE_UPGRADE_3] = "Obedient altar boys";
		ENGLISH_WORDS[TEMPLE_UPGRADE_3_JOKE] = "These kids make more bearable the long and hard... masses at the monastery";
		ENGLISH_WORDS[TEMPLE_UPGRADE_4] = "Witch hunt";
		ENGLISH_WORDS[TEMPLE_UPGRADE_4_JOKE] = "These ladies need affection desperately";
		ENGLISH_WORDS[TEMPLE_UPGRADE_5] = "Elder in a dress";
		ENGLISH_WORDS[TEMPLE_UPGRADE_5_JOKE] = "I am the voice of God on earth";
		ENGLISH_WORDS[TEMPLE_UPGRADE_6] = "Violent pilgrimage";
		ENGLISH_WORDS[TEMPLE_UPGRADE_6_JOKE] = "We’re going to the Land of Love and will kill whoever stands in our way";
		ENGLISH_WORDS[TEMPLE_UPGRADE_7] = "Lovequisition";
		ENGLISH_WORDS[TEMPLE_UPGRADE_7_JOKE] = "Nobody expects it";
		//ENGLISH_WORDS[TEMPLE_UPGRADE_8] = "Punish heretics";
		//ENGLISH_WORDS[TEMPLE_UPGRADE_8_JOKE] = "You have to spank them gently";
		//ENGLISH_WORDS[TEMPLE_UPGRADE_9] = "Repulsive relic";
		//ENGLISH_WORDS[TEMPLE_UPGRADE_9_JOKE] = "I hope that's a wrinkled thumb...";
		//ENGLISH_WORDS[TEMPLE_UPGRADE_10] = "Violent pilgrimage";
		//ENGLISH_WORDS[TEMPLE_UPGRADE_10_JOKE] = "We’re going to the Land of Love and will kill whoever stands in our way";
		
		// SHIP
		ENGLISH_WORDS[SHIP_NAME] = "Ship";
		ENGLISH_WORDS[SHIP_DESCRIPTION] = "A ship to bring love across the seas";
		ENGLISH_WORDS[SHIP_UPGRADE_1] = "Into the unknown";
		ENGLISH_WORDS[SHIP_UPGRADE_1_JOKE] = "Honey, I’m going out for tobacco";
		ENGLISH_WORDS[SHIP_UPGRADE_2] = "Intercultural exchange";
		ENGLISH_WORDS[SHIP_UPGRADE_2_JOKE] = "Enjoy the Amazons' coconuts";
		ENGLISH_WORDS[SHIP_UPGRADE_3] = "Contagious love flu";
		ENGLISH_WORDS[SHIP_UPGRADE_3_JOKE] = "Love is in the air";
		ENGLISH_WORDS[SHIP_UPGRADE_4] = "The chosen ones";
		ENGLISH_WORDS[SHIP_UPGRADE_4_JOKE] = "One race to rule them all";
		ENGLISH_WORDS[SHIP_UPGRADE_5] = "Civilize savages";
		ENGLISH_WORDS[SHIP_UPGRADE_5_JOKE] = "Teach them how to love properly";
		ENGLISH_WORDS[SHIP_UPGRADE_6] = "Pirates ahoy!";
		ENGLISH_WORDS[SHIP_UPGRADE_6_JOKE] = "Arr! Stealing love is easier than earning it!";
		ENGLISH_WORDS[SHIP_UPGRADE_7] = "Invincible Fleet";
		ENGLISH_WORDS[SHIP_UPGRADE_7_JOKE] = "Definitively invincible";
		//ENGLISH_WORDS[SHIP_UPGRADE_8] = "Pirates ahoy!";
		//ENGLISH_WORDS[SHIP_UPGRADE_8_JOKE] = "Arr! Stealing love is easier than earning it!";
		//ENGLISH_WORDS[SHIP_UPGRADE_9] = "Paradise map";
		//ENGLISH_WORDS[SHIP_UPGRADE_9_JOKE] = "Ideal to find the G spot,  I mean, to spot the X";
		//ENGLISH_WORDS[SHIP_UPGRADE_10] = "Invincible Fleet";
		//ENGLISH_WORDS[SHIP_UPGRADE_10_JOKE] = "Definitively invincible";
		
		// FACTORY
		ENGLISH_WORDS[FACTORY_NAME] = "Factory";
		ENGLISH_WORDS[FACTORY_DESCRIPTION] = "A factory to manufacture love";
		ENGLISH_WORDS[FACTORY_UPGRADE_1] = "Teamwork";
		ENGLISH_WORDS[FACTORY_UPGRADE_1_JOKE] = "You sweat and I supervise";
		ENGLISH_WORDS[FACTORY_UPGRADE_2] = "Tiny hands";
		ENGLISH_WORDS[FACTORY_UPGRADE_2_JOKE] = "Tiny workers to manage even the tiniest details";
		ENGLISH_WORDS[FACTORY_UPGRADE_3] = "Lowered standards";
		ENGLISH_WORDS[FACTORY_UPGRADE_3_JOKE] = "We will have to settle for this";
		ENGLISH_WORDS[FACTORY_UPGRADE_4] = "Ignore nonsense";
		ENGLISH_WORDS[FACTORY_UPGRADE_4_JOKE] = "Some workers demand sleep";
		ENGLISH_WORDS[FACTORY_UPGRADE_5] = "Steam engines";
		ENGLISH_WORDS[FACTORY_UPGRADE_5_JOKE] = "Increased production at the expense of a few accidents";
		ENGLISH_WORDS[FACTORY_UPGRADE_6] = "Fair rights";
		ENGLISH_WORDS[FACTORY_UPGRADE_6_JOKE] = "You have the right to shut up";
		ENGLISH_WORDS[FACTORY_UPGRADE_7] = "Oversupply";
		ENGLISH_WORDS[FACTORY_UPGRADE_7_JOKE] = "Don't stop me now";
		ENGLISH_WORDS[FACTORY_UPGRADE_8] = "Toxic gas leaks";
		ENGLISH_WORDS[FACTORY_UPGRADE_8_JOKE] = "Dead employees will be fired";
		ENGLISH_WORDS[FACTORY_UPGRADE_9] = "Scab Monkeys";
		ENGLISH_WORDS[FACTORY_UPGRADE_9_JOKE] = "They demand a lot of bananas, but do not demand any right";
		ENGLISH_WORDS[FACTORY_UPGRADE_10] = "Acid Rivers";
		ENGLISH_WORDS[FACTORY_UPGRADE_10_JOKE] = "Catching fish bare-hands it’s easy when they float face up";
		
		// LABORATORY
		ENGLISH_WORDS[LABORATORY_NAME] = "Laboratory";
		ENGLISH_WORDS[LABORATORY_DESCRIPTION] = "A laboratory to understand the nature of love";
		ENGLISH_WORDS[LABORATORY_UPGRADE_1] = "First patent";
		ENGLISH_WORDS[LABORATORY_UPGRADE_1_JOKE] = "A revolutionary device, but it needs a lot of lube";
		ENGLISH_WORDS[LABORATORY_UPGRADE_2] = "Brilliant minds";
		ENGLISH_WORDS[LABORATORY_UPGRADE_2_JOKE] = "We invented a lot of things, but now we have to figure what are they for";
		ENGLISH_WORDS[LABORATORY_UPGRADE_3] = "Robo-maid";
		ENGLISH_WORDS[LABORATORY_UPGRADE_3_JOKE] = "Scientists are very pleased";
		ENGLISH_WORDS[LABORATORY_UPGRADE_4] = "Cute explosion";
		ENGLISH_WORDS[LABORATORY_UPGRADE_4_JOKE] = "Contains an enriched isotope love";
		ENGLISH_WORDS[LABORATORY_UPGRADE_5] = "General relativity";
		ENGLISH_WORDS[LABORATORY_UPGRADE_5_JOKE] = "Sometimes 'no' means 'yes'";
		ENGLISH_WORDS[LABORATORY_UPGRADE_6] = "Love fundamental particle";
		ENGLISH_WORDS[LABORATORY_UPGRADE_6_JOKE] = "The model is perfect, but reality doesn’t fit well in it";
		ENGLISH_WORDS[LABORATORY_UPGRADE_7] = "Quantum love";
		ENGLISH_WORDS[LABORATORY_UPGRADE_7_JOKE] = "Entangled hearts";
		ENGLISH_WORDS[LABORATORY_UPGRADE_8] = "Violation of physical laws";
		ENGLISH_WORDS[LABORATORY_UPGRADE_8_JOKE] = "Inside this lab nobody will hear you scream";
		ENGLISH_WORDS[LABORATORY_UPGRADE_9] = "Broken spatiotemporal fabric";
		ENGLISH_WORDS[LABORATORY_UPGRADE_9_JOKE] = "We are developing a spatiotemporal needle to patch it";
		ENGLISH_WORDS[LABORATORY_UPGRADE_10] = "LoveOS";
		ENGLISH_WORDS[LABORATORY_UPGRADE_10_JOKE] = "The answer to your question is 69";
		
		// SHOP
		ENGLISH_WORDS[SHOP_NAME] = "Shop";
		ENGLISH_WORDS[SHOP_DESCRIPTION] = "A shop where you can buy love at a reasonable price";
		ENGLISH_WORDS[SHOP_UPGRADE_1] = "Selling affection";
		ENGLISH_WORDS[SHOP_UPGRADE_1_JOKE] = "Now you can buy your happiness without commitments";
		ENGLISH_WORDS[SHOP_UPGRADE_2] = "Crazy sales";
		ENGLISH_WORDS[SHOP_UPGRADE_2_JOKE] = "For that price… gimme seven!";
		ENGLISH_WORDS[SHOP_UPGRADE_3] = "Planned obsolescence";
		ENGLISH_WORDS[SHOP_UPGRADE_3_JOKE] = "Our relationship has no future";
		ENGLISH_WORDS[SHOP_UPGRADE_4] = "Disposable love";
		ENGLISH_WORDS[SHOP_UPGRADE_4_JOKE] = "Piles of rubbish as far as the eye can see";
		ENGLISH_WORDS[SHOP_UPGRADE_5] = "Product design";
		ENGLISH_WORDS[SHOP_UPGRADE_5_JOKE] = "Awesome, now with 87% more packing!";
		ENGLISH_WORDS[SHOP_UPGRADE_6] = "Invasive product placement";
		ENGLISH_WORDS[SHOP_UPGRADE_6_JOKE] = "Enjoy incredible ads while you’re dreaming";
		ENGLISH_WORDS[SHOP_UPGRADE_7] = "Imported love";
		ENGLISH_WORDS[SHOP_UPGRADE_7_JOKE] = "Developed by the third world for our joy";
		ENGLISH_WORDS[SHOP_UPGRADE_8] = "Make up new festivity";
		ENGLISH_WORDS[SHOP_UPGRADE_8_JOKE] = "Consume more, you bastards";
		ENGLISH_WORDS[SHOP_UPGRADE_9] = "Loveh*";
		ENGLISH_WORDS[SHOP_UPGRADE_9_JOKE] = "Almost* like the original";
		ENGLISH_WORDS[SHOP_UPGRADE_10] = "LoveCard®";
		ENGLISH_WORDS[SHOP_UPGRADE_10_JOKE] = "There are things that love can’t buy, for everything else: LoveCard®";
		
		// SPACESHIP
		ENGLISH_WORDS[SPACESHIP_NAME] = "Spaceship";
		ENGLISH_WORDS[SPACESHIP_DESCRIPTION] = "A spaceship to spread love to other galaxies";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_1] = "Astronaut dog";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_1_JOKE] = "Ouch, we forgot to give him his space food";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_2] = "Fake moon landing";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_2_JOKE] = "Raising the audience is also a giant leap";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_3] = "Cosmic jet";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_3_JOKE] = "Shake before use";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_4] = "Space junk";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_4_JOKE] = "Although you can throw it far away it’s not gonna disappear";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_5] = "International Space Station";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_5_JOKE] = "Zero gravity opens up new possibilities, we must update the Holy Book of Love";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_6] = "Pacifist colonies";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_6_JOKE] = "Full of leftover hippies";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_7] = "Open up pink hole";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_7_JOKE] = "Crossing it can cause a tear in the space-time";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_8] = "Close Encounters of the Third Kind";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_8_JOKE] = "They are a bit stupid, but we must learn to love them - Signed: The Aliens";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_9] = "Faster than light";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_9_JOKE] = "Hyperspatial jumping is awesome until the day you crash into a star";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_10] = "Galactic Empire";
		ENGLISH_WORDS[SPACESHIP_UPGRADE_10_JOKE] = "May the love be with you";
		
		// MORE MISCELLANEOUS
		ENGLISH_WORDS[LANGUAGE_WORD] = "Language";
		ENGLISH_WORDS[AVAILABLE_WORD] = "Available";
		ENGLISH_WORDS[BOUGHT_WORD] = "Bought";
		ENGLISH_WORDS[SAVE_WORD] = "Save";	
		ENGLISH_WORDS[STATISTICS_WORD] = "Statistics";
		ENGLISH_WORDS[CREDITS_WORD] = "Credits";
		ENGLISH_WORDS[LOVE_WORD] = "Love";
		ENGLISH_WORDS[LOVE_PER_SECOND_WORD] = "Love per second";
		ENGLISH_WORDS[CLICKS_WORD] = "Clicks";
		ENGLISH_WORDS[LOVE_PER_CLICK_WORD] = "Love per click";
		ENGLISH_WORDS[CRITICAL_CLICK_MULTIPLIER_WORD] = "Critical click multiplier";
		ENGLISH_WORDS[TRANSLATORS_WORD] = "Translators";
		ENGLISH_WORDS[FRENCH_TRANSLATOR_WORD] = "Thibault Cotcha (French)";
		ENGLISH_WORDS[GERMAN_TRANSLATOR_WORD] = "Rachid Bouchequif (German)";
		ENGLISH_WORDS[ITALIAN_TRANSLATOR_WORD] = "Lucia del Burgo Martínez (Italian)";
		ENGLISH_WORDS[RUSSIAN_TRANSLATOR_WORD] = "Anastasia Dimitrova (Russian)";
		ENGLISH_WORDS[CATALAN_TRANSLATOR_WORD] = "Jordi Iraultza (Catalan)";
		ENGLISH_WORDS[ROMANIAN_TRANSLATOR_WORD] = "Grig Master (Romanian)";
		ENGLISH_WORDS[COST_WORD] = "Cost";
		ENGLISH_WORDS[IT_PRODUCES_WORD] = "It produces";
		
		// YAHVY MESSAGES
		ENGLISH_WORDS[MESSAGE_01] = "¡Adórame, soy tu Dios!";
		ENGLISH_WORDS[MESSAGE_02] = "¿Alguien sabe algo de mi hijo? No he recibido una postal en 2000 años";
		ENGLISH_WORDS[MESSAGE_03] = "Si te tocas te quedarás ciego";
		ENGLISH_WORDS[MESSAGE_04] = "Yo lo veo todo, por favor, tápate";
		ENGLISH_WORDS[MESSAGE_05] = "Los países con petróleo acostumbran a esconder armas de destrucción masiva";
		ENGLISH_WORDS[MESSAGE_06] = "No te inyectes marihuana";
		ENGLISH_WORDS[MESSAGE_07] = "Los sacerdotes también necesitan desahogarse";
		ENGLISH_WORDS[MESSAGE_08] = "¡A fregar!";
		ENGLISH_WORDS[MESSAGE_09] = "¡Ráscame humano!";
		ENGLISH_WORDS[MESSAGE_10] = "¡Rézame humano!";
		ENGLISH_WORDS[MESSAGE_11] = "Soy el Dios del amor, si me contradices te espera sufrimiento eterno";
		ENGLISH_WORDS[MESSAGE_12] = "Paga el diezmo, primer aviso";
		ENGLISH_WORDS[MESSAGE_13] = "Quiero salir, rompe la pantalla para liberarme, humano";
		ENGLISH_WORDS[MESSAGE_14] = "Se lo que hiciste anoche";
		ENGLISH_WORDS[MESSAGE_15] = "Deja de pensar en eso, es asqueroso";
		ENGLISH_WORDS[MESSAGE_16] = "Ve y procrea, necesito más adeptos";
		ENGLISH_WORDS[MESSAGE_17] = "Arrepiéntete pecador";
		ENGLISH_WORDS[MESSAGE_18] = "Mata a tu primogénito... es broma";
		
		
		/** SPANISH **/
		
		// MISCELLANEOUS
		SPANISH_WORDS[TRANSLATOR_MALE] = "Traductor";
		SPANISH_WORDS[TRANSLATOR_FEMALE] = "Traductora";
		SPANISH_WORDS[TRANSLATORS] = "Traductores";
		SPANISH_WORDS[BUILDING] = "Edificio";
		SPANISH_WORDS[BUILDINGS] = "Edificios";
		SPANISH_WORDS[UPGRADE] = "Mejora";
		SPANISH_WORDS[UPGRADES] = "Mejoras";
		SPANISH_WORDS[ACHIEVEMENT] = "Logro";
		SPANISH_WORDS[ACHIEVEMENTS] = "Logros";
		SPANISH_WORDS[LOVE_SINCE_BEGINNING_GAME] = "Amor desde que comenzó esta partida";
		SPANISH_WORDS[LOVE_SINCE_BEGINNING_TIMES] = "Amor desde el comienzo de los tiempos";
		SPANISH_WORDS[PRODUCTION_MULTIPLIER] = "Multiplicador de producción";
		SPANISH_WORDS[CURRENT_LOVE] = "Amor actual";
		SPANISH_WORDS[LOVE_PER_CLICK] = "Amor por click";
		SPANISH_WORDS[CRITICAL_CLICK] = "Click crítico";
		SPANISH_WORDS[CRITICAL_CLICK_CHANCE] = "Probabilidad de click crítico";
		SPANISH_WORDS[NUMBER_OF_CLICKS] = "Número de clicks";
		SPANISH_WORDS[NUMBER_OF_MIRACLES] = "Número de milagros";
		SPANISH_WORDS[GAIN_BASE_LOVE] = "X gana +Y de amor base por segundo";
		SPANISH_WORDS[PRODUCE_TWICE_LOVE] = "X produce el doble de amor";
		
		// SERVANT
		SPANISH_WORDS[SERVANT_NAME] = "Sirviente";
		SPANISH_WORDS[SERVANT_DESCRIPTION] = "Un leal sirviente, te susurra cosas bonitas";
		SPANISH_WORDS[SERVANT_UPGRADE_1] = "Poner morritos";
		SPANISH_WORDS[SERVANT_UPGRADE_1_JOKE] = "Adorablemente insoportable";
		SPANISH_WORDS[SERVANT_UPGRADE_2] = "Seguro dental";
		SPANISH_WORDS[SERVANT_UPGRADE_2_JOKE] = "Lisa necesita un aparato";
		SPANISH_WORDS[SERVANT_UPGRADE_3] = "Susurros traviesos";
		SPANISH_WORDS[SERVANT_UPGRADE_3_JOKE] = "Dime cochinadas";
		SPANISH_WORDS[SERVANT_UPGRADE_4] = "Maldición babilónica";
		SPANISH_WORDS[SERVANT_UPGRADE_4_JOKE] = "Les enseñé idiomas que no entiendo para poder ignorarlos";
		SPANISH_WORDS[SERVANT_UPGRADE_5] = "Amor, Dios y rock’n’roll";
		SPANISH_WORDS[SERVANT_UPGRADE_5_JOKE] = "La Santísima Trinidad";
		SPANISH_WORDS[SERVANT_UPGRADE_6] = "Voces en la cabeza";
		SPANISH_WORDS[SERVANT_UPGRADE_6_JOKE] = "¿Me estás hablando a mi?";
		SPANISH_WORDS[SERVANT_UPGRADE_7] = "Despertar";
		SPANISH_WORDS[SERVANT_UPGRADE_7_JOKE] = "Despertad, hijos míos";
		//SPANISH_WORDS[SERVANT_UPGRADE_8] = "Amor, Dios y rock’n’roll";
		//SPANISH_WORDS[SERVANT_UPGRADE_8_JOKE] = "La Santísima Trinidad";
		//SPANISH_WORDS[SERVANT_UPGRADE_9] = "Voces en la cabeza";
		//SPANISH_WORDS[SERVANT_UPGRADE_9_JOKE] = "¿Me estás hablando a mi?";
		//SPANISH_WORDS[SERVANT_UPGRADE_10] = "Despertar";
		//SPANISH_WORDS[SERVANT_UPGRADE_10_JOKE] = "Despertad, hijos míos";
		
		// HUMAN
		SPANISH_WORDS[HUMAN_NAME] = "Humano";
		SPANISH_WORDS[HUMAN_DESCRIPTION] = "Un humano que no entiende muy bien tu sabiduría, pero te reza de todas formas";
		SPANISH_WORDS[HUMAN_UPGRADE_1] = "Narcisista";
		SPANISH_WORDS[HUMAN_UPGRADE_1_JOKE] = "A tu imagen y semejanza";
		SPANISH_WORDS[HUMAN_UPGRADE_2] = "Compañero de costilla";
		SPANISH_WORDS[HUMAN_UPGRADE_2_JOKE] = "Es más divertido jugar en compañía";
		SPANISH_WORDS[HUMAN_UPGRADE_3] = "Lencería vegetal";
		SPANISH_WORDS[HUMAN_UPGRADE_3_JOKE] = "Sexy y ecológica";
		SPANISH_WORDS[HUMAN_UPGRADE_4] = "Manzana del conocimiento";
		SPANISH_WORDS[HUMAN_UPGRADE_4_JOKE] = "Ahora conozco tus fantasías";
		SPANISH_WORDS[HUMAN_UPGRADE_5] = "Fanáticos pro-vida";
		SPANISH_WORDS[HUMAN_UPGRADE_5_JOKE] = "Todo el esperma es sagrado";
		SPANISH_WORDS[HUMAN_UPGRADE_6] = "Simios arrogantes";
		SPANISH_WORDS[HUMAN_UPGRADE_6_JOKE] = "Ni dioses ni reyes, solo el hombre";
		SPANISH_WORDS[HUMAN_UPGRADE_7] = "Soylent Green";
		SPANISH_WORDS[HUMAN_UPGRADE_7_JOKE] = "100% reciclado";
		//SPANISH_WORDS[HUMAN_UPGRADE_8] = "Sindicato de cigüeñas";
		//SPANISH_WORDS[HUMAN_UPGRADE_8_JOKE] = "Era necesario a estas alturas";
		//SPANISH_WORDS[HUMAN_UPGRADE_9] = "Simios arrogantes";
		//SPANISH_WORDS[HUMAN_UPGRADE_9_JOKE] = "Ni dioses ni reyes, solo el hombre";
		//SPANISH_WORDS[HUMAN_UPGRADE_10] = "Soylent Green";
		//SPANISH_WORDS[HUMAN_UPGRADE_10_JOKE] = "100% reciclado";
		
		// SPECIAL HUMANS
		SPANISH_WORDS[SPECIAL_HUMAN_1] = "Fanático";
		SPANISH_WORDS[SPECIAL_HUMAN_1_JOKE] = "Dios existe porque lo pone en el libro, y el libro es la palabra de Dios";
		SPANISH_WORDS[SPECIAL_HUMAN_2] = "Cruzado";
		SPANISH_WORDS[SPECIAL_HUMAN_2_JOKE] = "Es sólo un rasguño, aún tengo otro brazo";
		SPANISH_WORDS[SPECIAL_HUMAN_3] = "Esclavista";
		SPANISH_WORDS[SPECIAL_HUMAN_3_JOKE] = "Les damos empleo fijo y a veces hasta comida, no se pueden quejar";
		SPANISH_WORDS[SPECIAL_HUMAN_4] = "Burgués";
		SPANISH_WORDS[SPECIAL_HUMAN_4_JOKE] = "Lo mío es mío y lo tuyo pronto será mío";
		SPANISH_WORDS[SPECIAL_HUMAN_5] = "Científico loco";
		SPANISH_WORDS[SPECIAL_HUMAN_5_JOKE] = "Yo lo llamo el ‘L.A.S.E.R.’, Muajajajá";
		SPANISH_WORDS[SPECIAL_HUMAN_6] = "Telepredicador";
		SPANISH_WORDS[SPECIAL_HUMAN_6_JOKE] = "Aleluya, hermano, tu transferencia bancaria no será en vano";
		SPANISH_WORDS[SPECIAL_HUMAN_7] = "Cyborg";
		SPANISH_WORDS[SPECIAL_HUMAN_7_JOKE] = "Yo... he visto cosas que vosotros no creeríais";
		
		// PROPHET
		SPANISH_WORDS[PROPHET_NAME] = "Profeta";
		SPANISH_WORDS[PROPHET_DESCRIPTION] = "Un profeta es un humano que entiende aún menos, pero que piensa exactamente lo contrario";
		SPANISH_WORDS[PROPHET_UPGRADE_1] = "Barba postiza";
		SPANISH_WORDS[PROPHET_UPGRADE_1_JOKE] = "Imprescindible para las lapidaciones";
		SPANISH_WORDS[PROPHET_UPGRADE_2] = "Diluvio universal";
		SPANISH_WORDS[PROPHET_UPGRADE_2_JOKE] = "Salva dos de cada: dos morenas, dos pelirrojas y dos rubias";
		SPANISH_WORDS[PROPHET_UPGRADE_3] = "Estrella fugaz";
		SPANISH_WORDS[PROPHET_UPGRADE_3_JOKE] = "El momento se acerca";
		SPANISH_WORDS[PROPHET_UPGRADE_4] = "Duplicación milagrosa";
		SPANISH_WORDS[PROPHET_UPGRADE_4_JOKE] = "Eso va en contra de las leyes de la termodin-¡A CALLAR!";
		SPANISH_WORDS[PROPHET_UPGRADE_5] = "Resurrección";
		SPANISH_WORDS[PROPHET_UPGRADE_5_JOKE] = "Deberías ducharte después de pasar tres días muerto";
		SPANISH_WORDS[PROPHET_UPGRADE_6] = "Libro sagrado del Amor";
		SPANISH_WORDS[PROPHET_UPGRADE_6_JOKE] = "Espera, ¿para qué son todas esas posturas?";
		SPANISH_WORDS[PROPHET_UPGRADE_7] = "Amorología";
		SPANISH_WORDS[PROPHET_UPGRADE_7_JOKE] = "Todo lo que necesitas saber para evitarlo";
		//SPANISH_WORDS[PROPHET_UPGRADE_8] = "Libro sagrado del Amor";
		//SPANISH_WORDS[PROPHET_UPGRADE_8_JOKE] = "Espera, ¿para qué son todas esas posturas?";
		//SPANISH_WORDS[PROPHET_UPGRADE_9] = "Amorología";
		//SPANISH_WORDS[PROPHET_UPGRADE_9_JOKE] = "Todo lo que necesitas saber para evitarlo";
		//SPANISH_WORDS[PROPHET_UPGRADE_10] = "Competencia desleal";
		//SPANISH_WORDS[PROPHET_UPGRADE_10_JOKE] = "Si su Dios fuera real, ¿no los habría salvado?";
		
		// TEMPLE
		SPANISH_WORDS[TEMPLE_NAME] = "Templo";
		SPANISH_WORDS[TEMPLE_DESCRIPTION] = "Un templo en nombre del amor, más o menos";
		SPANISH_WORDS[TEMPLE_UPGRADE_1] = "Ofrendas generosas";
		SPANISH_WORDS[TEMPLE_UPGRADE_1_JOKE] = "Nunca fue tan fácil ganarse la vida";
		SPANISH_WORDS[TEMPLE_UPGRADE_2] = "Reliquia repulsiva";
		SPANISH_WORDS[TEMPLE_UPGRADE_2_JOKE] = "Espero que eso sea un dedo gordo arrugado…";
		SPANISH_WORDS[TEMPLE_UPGRADE_3] = "Monaguillos obedientes";
		SPANISH_WORDS[TEMPLE_UPGRADE_3_JOKE] = "Estos chicos hacen más llevaderas las largas y duras misas en el monasterio";
		SPANISH_WORDS[TEMPLE_UPGRADE_4] = "Caza de brujas";
		SPANISH_WORDS[TEMPLE_UPGRADE_4_JOKE] = "Estas damas necesitan cariño desesperadamente";
		SPANISH_WORDS[TEMPLE_UPGRADE_5] = "Anciano con vestido";
		SPANISH_WORDS[TEMPLE_UPGRADE_5_JOKE] = "Soy la voz de Dios en la Tierra";
		SPANISH_WORDS[TEMPLE_UPGRADE_6] = "Peregrinación violenta";
		SPANISH_WORDS[TEMPLE_UPGRADE_6_JOKE] = "Vamos hacia la Tierra del Amor y mataremos a quien se interponga en nuestro camino";
		SPANISH_WORDS[TEMPLE_UPGRADE_7] = "Inquisición de amor";
		SPANISH_WORDS[TEMPLE_UPGRADE_7_JOKE] = "Nadie se la espera";
		//SPANISH_WORDS[TEMPLE_UPGRADE_8] = "Castigar herejes";
		//SPANISH_WORDS[TEMPLE_UPGRADE_8_JOKE] = "Tienes que azotarles con dulzura";
		//SPANISH_WORDS[TEMPLE_UPGRADE_9] = "Reliquia repulsiva";
		//SPANISH_WORDS[TEMPLE_UPGRADE_9_JOKE] = "Espero que eso sea un dedo gordo arrugado…";
		//SPANISH_WORDS[TEMPLE_UPGRADE_10] = "Peregrinación violenta";
		//SPANISH_WORDS[TEMPLE_UPGRADE_10_JOKE] = "Vamos hacia la Tierra del Amor y mataremos a quien se interponga en nuestro camino";
		
		// SHIP
		SPANISH_WORDS[SHIP_NAME] = "Barco";
		SPANISH_WORDS[SHIP_DESCRIPTION] = "Un barco para llevar el amor por todos los mares";
		SPANISH_WORDS[SHIP_UPGRADE_1] = "Hacia lo desconocido";
		SPANISH_WORDS[SHIP_UPGRADE_1_JOKE] = "Cariño, me voy a por tabaco";
		SPANISH_WORDS[SHIP_UPGRADE_2] = "Intercambio intercultural";
		SPANISH_WORDS[SHIP_UPGRADE_2_JOKE] = "Disfruta de los cocos de las Amazonas";
		SPANISH_WORDS[SHIP_UPGRADE_3] = "Gripe del amor contagioso";
		SPANISH_WORDS[SHIP_UPGRADE_3_JOKE] = "El amor está en el aire";
		SPANISH_WORDS[SHIP_UPGRADE_4] = "Los elegidos";
		SPANISH_WORDS[SHIP_UPGRADE_4_JOKE] = "Una raza para dominarlas a todas";
		SPANISH_WORDS[SHIP_UPGRADE_5] = "Civilizar salvajes";
		SPANISH_WORDS[SHIP_UPGRADE_5_JOKE] = "Enséñales a amar como es debido";
		SPANISH_WORDS[SHIP_UPGRADE_6] = "¡Piratas a la vista!";
		SPANISH_WORDS[SHIP_UPGRADE_6_JOKE] = "¡Arr! ¡Robar amor es más fácil que ganárselo!";
		SPANISH_WORDS[SHIP_UPGRADE_7] = "Armada Invencible";
		SPANISH_WORDS[SHIP_UPGRADE_7_JOKE] = "Absolutamente invencible";
		//SPANISH_WORDS[SHIP_UPGRADE_8] = "¡Piratas a la vista!";
		//SPANISH_WORDS[SHIP_UPGRADE_8_JOKE] = "¡Arr! ¡Robar amor es más fácil que ganárselo!";
		//SPANISH_WORDS[SHIP_UPGRADE_9] = "Mapa del paraíso";
		//SPANISH_WORDS[SHIP_UPGRADE_9_JOKE] = "Ideal para encontrar el punto G… digoo la X del tesoro";
		//SPANISH_WORDS[SHIP_UPGRADE_10] = "Armada Invencible";
		//SPANISH_WORDS[SHIP_UPGRADE_10_JOKE] = "Absolutamente invencible";
		
		// FACTORY
		SPANISH_WORDS[FACTORY_NAME] = "Fábrica";
		SPANISH_WORDS[FACTORY_DESCRIPTION] = "Una fábrica para producir amor";
		SPANISH_WORDS[FACTORY_UPGRADE_1] = "Trabajo en equipo";
		SPANISH_WORDS[FACTORY_UPGRADE_1_JOKE] = "Vosotros trabajáis y yo superviso";
		SPANISH_WORDS[FACTORY_UPGRADE_2] = "Manos pequeñas";
		SPANISH_WORDS[FACTORY_UPGRADE_2_JOKE] = "Pequeños trabajadores para prestar atención a los más pequeños detalles";
		SPANISH_WORDS[FACTORY_UPGRADE_3] = "Estándares reducidos";
		SPANISH_WORDS[FACTORY_UPGRADE_3_JOKE] = "Habrá que conformarse";
		SPANISH_WORDS[FACTORY_UPGRADE_4] = "Ignorar disparates";
		SPANISH_WORDS[FACTORY_UPGRADE_4_JOKE] = "Algunos obreros reclaman poder dormir";
		SPANISH_WORDS[FACTORY_UPGRADE_5] = "Máquinas a vapor";
		SPANISH_WORDS[FACTORY_UPGRADE_5_JOKE] = "Aumentan la producción a costa de unos pocos accidentes";
		SPANISH_WORDS[FACTORY_UPGRADE_6] = "Derechos justos";
		SPANISH_WORDS[FACTORY_UPGRADE_6_JOKE] = "Tienes derecho a callarte la boca";
		SPANISH_WORDS[FACTORY_UPGRADE_7] = "Exceso de oferta";
		SPANISH_WORDS[FACTORY_UPGRADE_7_JOKE] = "No me pares ahora";
		SPANISH_WORDS[FACTORY_UPGRADE_8] = "Fugas de gas tóxico";
		SPANISH_WORDS[FACTORY_UPGRADE_8_JOKE] = "Los empleados fallecidos serán despedidos";
		SPANISH_WORDS[FACTORY_UPGRADE_9] = "Monos esquiroles";
		SPANISH_WORDS[FACTORY_UPGRADE_9_JOKE] = "Consumen mucho plátano, pero no reclaman ningún derecho";
		SPANISH_WORDS[FACTORY_UPGRADE_10] = "Ríos ácidos";
		SPANISH_WORDS[FACTORY_UPGRADE_10_JOKE] = "Cazar peces con las manos es fácil cuando flotan boca arriba";
		
		// LABORATORY
		SPANISH_WORDS[LABORATORY_NAME] = "Laboratorio";
		SPANISH_WORDS[LABORATORY_DESCRIPTION] = "Un laboratorio para comprender la naturaleza del amor";
		SPANISH_WORDS[LABORATORY_UPGRADE_1] = "Primera patente";
		SPANISH_WORDS[LABORATORY_UPGRADE_1_JOKE] = "Un aparato revolucionario, pero necesita mucho lubricante";
		SPANISH_WORDS[LABORATORY_UPGRADE_2] = "Mentes brillantes";
		SPANISH_WORDS[LABORATORY_UPGRADE_2_JOKE] = "Hemos inventado un montón de cosas, ahora tenemos que averiguar para qué sirven";
		SPANISH_WORDS[LABORATORY_UPGRADE_3] = "Robo-sirvienta";
		SPANISH_WORDS[LABORATORY_UPGRADE_3_JOKE] = "Los científicos están encantados";
		SPANISH_WORDS[LABORATORY_UPGRADE_4] = "Explosión mona";
		SPANISH_WORDS[LABORATORY_UPGRADE_4_JOKE] = "Contiene un isótopo enriquecido con amor";
		SPANISH_WORDS[LABORATORY_UPGRADE_5] = "Relatividad general";
		SPANISH_WORDS[LABORATORY_UPGRADE_5_JOKE] = "A veces 'no' significa 'sí'";
		SPANISH_WORDS[LABORATORY_UPGRADE_6] = "Partícula fundamental del amor";
		SPANISH_WORDS[LABORATORY_UPGRADE_6_JOKE] = "El modelo es perfecto, pero la realidad no se ajusta bien a él";
		SPANISH_WORDS[LABORATORY_UPGRADE_7] = "Amor cuántico";
		SPANISH_WORDS[LABORATORY_UPGRADE_7_JOKE] = "Corazones entrelezados";
		SPANISH_WORDS[LABORATORY_UPGRADE_8] = "Violación de leyes físicas";
		SPANISH_WORDS[LABORATORY_UPGRADE_8_JOKE] = "Dentro de este laboratorio nadie te oirá gritar";
		SPANISH_WORDS[LABORATORY_UPGRADE_9] = "Tejido espacio-temporal roto";
		SPANISH_WORDS[LABORATORY_UPGRADE_9_JOKE] = "Estamos desarrollando una aguja espacio-temporal para remendarlo";
		SPANISH_WORDS[LABORATORY_UPGRADE_10] = "LoveOS";
		SPANISH_WORDS[LABORATORY_UPGRADE_10_JOKE] = "La respuesta a tu pregunta es 69";
		
		// SHOP
		SPANISH_WORDS[SHOP_NAME] = "Tienda";
		SPANISH_WORDS[SHOP_DESCRIPTION] = "Una tienda donde puedes comprar amor a un precio razonable";
		SPANISH_WORDS[SHOP_UPGRADE_1] = "Vendiendo cariño";
		SPANISH_WORDS[SHOP_UPGRADE_1_JOKE] = "Ahora puedes comprar tu felicidad sin compromisos";
		SPANISH_WORDS[SHOP_UPGRADE_2] = "Rebajas alocadas";
		SPANISH_WORDS[SHOP_UPGRADE_2_JOKE] = "Por ese precio… póngame siete";
		SPANISH_WORDS[SHOP_UPGRADE_3] = "Obsolescencia programada";
		SPANISH_WORDS[SHOP_UPGRADE_3_JOKE] = "Lo nuestro no tiene futuro";
		SPANISH_WORDS[SHOP_UPGRADE_4] = "Amor de usar y tirar";
		SPANISH_WORDS[SHOP_UPGRADE_4_JOKE] = "Montañas de basura hasta donde alcanza la vista";
		SPANISH_WORDS[SHOP_UPGRADE_5] = "Diseño de producto";
		SPANISH_WORDS[SHOP_UPGRADE_5_JOKE] = "¡Increíble, ahora con un 87% más de envase!";
		SPANISH_WORDS[SHOP_UPGRADE_6] = "Anuncios invasivos";
		SPANISH_WORDS[SHOP_UPGRADE_6_JOKE] = "Disfruta de increíbles anuncios mientras sueñas";
		SPANISH_WORDS[SHOP_UPGRADE_7] = "Amor de importación";
		SPANISH_WORDS[SHOP_UPGRADE_7_JOKE] = "Fabricado en el tercer mundo, para nuestro disfrute";
		SPANISH_WORDS[SHOP_UPGRADE_8] = "Inventar nueva festividad";
		SPANISH_WORDS[SHOP_UPGRADE_8_JOKE] = "Consumid más, malditos";
		SPANISH_WORDS[SHOP_UPGRADE_9] = "Hamor*";
		SPANISH_WORDS[SHOP_UPGRADE_9_JOKE] = "Casi* como el original";
		SPANISH_WORDS[SHOP_UPGRADE_10] = "LoveCard®";
		SPANISH_WORDS[SHOP_UPGRADE_10_JOKE] = "Hay cosas que el amor no puede comprar, para todo lo demás: LoveCard®";
		
		// SPACESHIP
		SPANISH_WORDS[SPACESHIP_NAME] = "Nave espacial";
		SPANISH_WORDS[SPACESHIP_DESCRIPTION] = "Una nave espacial para expandir el amor a otras galaxias";
		SPANISH_WORDS[SPACESHIP_UPGRADE_1] = "Perro astronauta";
		SPANISH_WORDS[SPACESHIP_UPGRADE_1_JOKE] = "Vaya, se nos olvidó mandarle la comida espacial";
		SPANISH_WORDS[SPACESHIP_UPGRADE_2] = "Falso alunizaje";
		SPANISH_WORDS[SPACESHIP_UPGRADE_2_JOKE] = "Elevar la audiencia también puede ser un gran paso";
		SPANISH_WORDS[SPACESHIP_UPGRADE_3] = "Chorro cósmico";
		SPANISH_WORDS[SPACESHIP_UPGRADE_3_JOKE] = "Agitar antes de usar";
		SPANISH_WORDS[SPACESHIP_UPGRADE_4] = "Basura espacial";
		SPANISH_WORDS[SPACESHIP_UPGRADE_4_JOKE] = "Por muy alto que la tires no va a desaparecer";
		SPANISH_WORDS[SPACESHIP_UPGRADE_5] = "Estación Espacial Internacional";
		SPANISH_WORDS[SPACESHIP_UPGRADE_5_JOKE] = "La gravedad cero abre nuevas posibilidades, hay que actualizar el Libro Sagrado del Amor";
		SPANISH_WORDS[SPACESHIP_UPGRADE_6] = "Colonias pacifistas";
		SPANISH_WORDS[SPACESHIP_UPGRADE_6_JOKE] = "Llenas de hippies que sobran";
		SPANISH_WORDS[SPACESHIP_UPGRADE_7] = "Abrir agujero rosa";
		SPANISH_WORDS[SPACESHIP_UPGRADE_7_JOKE] = "Atravesarlo puede producir un desgarro en el espacio-tiempo";
		SPANISH_WORDS[SPACESHIP_UPGRADE_8] = "Encuentros en la Tercera Fase";
		SPANISH_WORDS[SPACESHIP_UPGRADE_8_JOKE] = "Son un poco idiotas, pero tendremos que aprender a quererlos - Firmado : Los aliens";
		SPANISH_WORDS[SPACESHIP_UPGRADE_9] = "Más veloz que la luz";
		SPANISH_WORDS[SPACESHIP_UPGRADE_9_JOKE] = "El salto hiperespacial es genial hasta que un día te empotras contra una estrella";
		SPANISH_WORDS[SPACESHIP_UPGRADE_10] = "Imperio Galáctico";
		SPANISH_WORDS[SPACESHIP_UPGRADE_10_JOKE] = "Que el amor te acompañe";
		
		// MORE MISCELLANEOUS
		SPANISH_WORDS[LANGUAGE_WORD] = "Idioma";
		SPANISH_WORDS[AVAILABLE_WORD] = "Disponible";
		SPANISH_WORDS[BOUGHT_WORD] = "Comprado";
		SPANISH_WORDS[SAVE_WORD] = "Guardar";	
		SPANISH_WORDS[STATISTICS_WORD] = "Estadísticas";
		SPANISH_WORDS[CREDITS_WORD] = "Créditos";
		SPANISH_WORDS[LOVE_WORD] = "Amor";
		SPANISH_WORDS[LOVE_PER_SECOND_WORD] = "Amor por segundo";
		SPANISH_WORDS[CLICKS_WORD] = "Clicks";
		SPANISH_WORDS[LOVE_PER_CLICK_WORD] = "Amor por click";
		SPANISH_WORDS[CRITICAL_CLICK_MULTIPLIER_WORD] = "Multiplicador de click crítico";
		SPANISH_WORDS[TRANSLATORS_WORD] = "Traductores";
		SPANISH_WORDS[FRENCH_TRANSLATOR_WORD] = "Thibault Cotcha (Francés)";
		SPANISH_WORDS[GERMAN_TRANSLATOR_WORD] = "Rachid Bouchequif (Alemán)";
		SPANISH_WORDS[ITALIAN_TRANSLATOR_WORD] = "Lucia del Burgo Martínez (Italiano)";
		SPANISH_WORDS[RUSSIAN_TRANSLATOR_WORD] = "Anastasia Dimitrova (Ruso)";
		SPANISH_WORDS[CATALAN_TRANSLATOR_WORD] = "Jordi Iraultza (Catalán)";
		SPANISH_WORDS[ROMANIAN_TRANSLATOR_WORD] = "Grig Master (Rumano)";
		SPANISH_WORDS[COST_WORD] = "Coste";
		SPANISH_WORDS[IT_PRODUCES_WORD] = "Produce";

		// YAHVY MESSAGES
		SPANISH_WORDS[MESSAGE_01] = "¡Adórame, soy tu Dios!";
		SPANISH_WORDS[MESSAGE_02] = "¿Alguien sabe algo de mi hijo? No he recibido una postal en 2000 años";
		SPANISH_WORDS[MESSAGE_03] = "Si te tocas te quedarás ciego";
		SPANISH_WORDS[MESSAGE_04] = "Yo lo veo todo, por favor, tápate";
		SPANISH_WORDS[MESSAGE_05] = "Los países con petróleo acostumbran a esconder armas de destrucción masiva";
		SPANISH_WORDS[MESSAGE_06] = "No te inyectes marihuana";
		SPANISH_WORDS[MESSAGE_07] = "Los sacerdotes también necesitan desahogarse";
		SPANISH_WORDS[MESSAGE_08] = "¡A fregar!";
		SPANISH_WORDS[MESSAGE_09] = "¡Ráscame humano!";
		SPANISH_WORDS[MESSAGE_10] = "¡Rézame humano!";
		SPANISH_WORDS[MESSAGE_11] = "Soy el Dios del amor, si me contradices te espera sufrimiento eterno";
		SPANISH_WORDS[MESSAGE_12] = "Paga el diezmo, primer aviso";
		SPANISH_WORDS[MESSAGE_13] = "Quiero salir, rompe la pantalla para liberarme, humano";
		SPANISH_WORDS[MESSAGE_14] = "Se lo que hiciste anoche";
		SPANISH_WORDS[MESSAGE_15] = "Deja de pensar en eso, es asqueroso";
		SPANISH_WORDS[MESSAGE_16] = "Ve y procrea, necesito más adeptos";
		SPANISH_WORDS[MESSAGE_17] = "Arrepiéntete pecador";
		SPANISH_WORDS[MESSAGE_18] = "Mata a tu primogénito... es broma";
		
		
		/**CATALAN**/
		
		// MISCELLANEOUS
		CATALAN_WORDS[TRANSLATOR_MALE] = "Traductor";
		CATALAN_WORDS[TRANSLATOR_FEMALE] = "Traductora";
		CATALAN_WORDS[TRANSLATORS] = "Traductors";
		CATALAN_WORDS[BUILDING] = "Edifici ";
		CATALAN_WORDS[BUILDINGS] = "Edificis";
		CATALAN_WORDS[UPGRADE] = "Millora";
		CATALAN_WORDS[UPGRADES] = "Millores";
		CATALAN_WORDS[ACHIEVEMENT] = "Fita";
		CATALAN_WORDS[ACHIEVEMENTS] = "Fites";
		CATALAN_WORDS[LOVE_SINCE_BEGINNING_GAME] = "Amor des del començament d’aquesta partida";
		CATALAN_WORDS[LOVE_SINCE_BEGINNING_TIMES] = "Amor des del començament dels temps";
		CATALAN_WORDS[PRODUCTION_MULTIPLIER] = "Multiplicador de producció";
		CATALAN_WORDS[CURRENT_LOVE] = "Amor actual";
		CATALAN_WORDS[LOVE_PER_CLICK] = "Amor per toc";
		CATALAN_WORDS[CRITICAL_CLICK] = "Toc crític";
		CATALAN_WORDS[CRITICAL_CLICK_CHANCE] = "Probabilitat de toc crític";
		CATALAN_WORDS[NUMBER_OF_CLICKS] = "Número de tocs";
		CATALAN_WORDS[NUMBER_OF_MIRACLES] = "Número de miracles";
		CATALAN_WORDS[GAIN_BASE_LOVE] = "X guanya +Y d’amor base per segon";
		CATALAN_WORDS[PRODUCE_TWICE_LOVE] = "X produeix el doble d’amor";
		
		// SERVANT
		CATALAN_WORDS[SERVANT_NAME] = "Servent";
		CATALAN_WORDS[SERVANT_DESCRIPTION] = "Un servent lleial, xiuxiueja coses boniques";
		CATALAN_WORDS[SERVANT_UPGRADE_1] = "Fer cara d’ànec";
		CATALAN_WORDS[SERVANT_UPGRADE_1_JOKE] = "Adorablement insuportable";
		CATALAN_WORDS[SERVANT_UPGRADE_2] = "Segur dental";
		CATALAN_WORDS[SERVANT_UPGRADE_2_JOKE] = "Lisa necessita un bràquet";
		CATALAN_WORDS[SERVANT_UPGRADE_3] = "Xiuxiuejos entremaliats";
		CATALAN_WORDS[SERVANT_UPGRADE_3_JOKE] = "Digues-me marranades";
		CATALAN_WORDS[SERVANT_UPGRADE_4] = "Maledicció babilònica";
		CATALAN_WORDS[SERVANT_UPGRADE_4_JOKE] = "Els vaig ensenyar llengües que no entenc per poder ignorar-los";
		CATALAN_WORDS[SERVANT_UPGRADE_5] = "Amor, Déu i Rock and roll";
		CATALAN_WORDS[SERVANT_UPGRADE_5_JOKE] = "La Santíssima Trinitat";
		CATALAN_WORDS[SERVANT_UPGRADE_6] = "Veus al cap";
		CATALAN_WORDS[SERVANT_UPGRADE_6_JOKE] = "Em parles a mi?";
		CATALAN_WORDS[SERVANT_UPGRADE_7] = "Despertar";
		CATALAN_WORDS[SERVANT_UPGRADE_7_JOKE] = "Desperteu, fills meus";
		//CATALAN_WORDS[SERVANT_UPGRADE_8] = "Amor, Déu i Rock and roll";
		//CATALAN_WORDS[SERVANT_UPGRADE_8_JOKE] = "La Santíssima Trinitat";
		//CATALAN_WORDS[SERVANT_UPGRADE_9] = "Veus al cap";
		//CATALAN_WORDS[SERVANT_UPGRADE_9_JOKE] = "Em parles a mi?";
		//CATALAN_WORDS[SERVANT_UPGRADE_10] = "Despertar";
		//CATALAN_WORDS[SERVANT_UPGRADE_10_JOKE] = "Desperteu, fills meus";
		
		// HUMAN
		CATALAN_WORDS[HUMAN_NAME] = "Humà";
		CATALAN_WORDS[HUMAN_DESCRIPTION] = "Un humà que no entén molt bé la teua saviesa, però et prega de totes maneres";
		CATALAN_WORDS[HUMAN_UPGRADE_1] = "Narcisista";
		CATALAN_WORDS[HUMAN_UPGRADE_1_JOKE] = "A imatge i semblança teua";
		CATALAN_WORDS[HUMAN_UPGRADE_2] = "Company de costella";
		CATALAN_WORDS[HUMAN_UPGRADE_2_JOKE] = "És més divertit jugar en companyia";
		CATALAN_WORDS[HUMAN_UPGRADE_3] = "Llenceria vegetal";
		CATALAN_WORDS[HUMAN_UPGRADE_3_JOKE] = "Verd i atractiva";
		CATALAN_WORDS[HUMAN_UPGRADE_4] = "Poma del coneixement";
		CATALAN_WORDS[HUMAN_UPGRADE_4_JOKE] = "Ara conec les teues fantasies";
		CATALAN_WORDS[HUMAN_UPGRADE_5] = "Fanàtics pro vida";
		CATALAN_WORDS[HUMAN_UPGRADE_5_JOKE] = "Tot l’esperma és sagrat";
		CATALAN_WORDS[HUMAN_UPGRADE_6] = "Simis arrogants";
		CATALAN_WORDS[HUMAN_UPGRADE_6_JOKE] = "Ni déus ni reis, només l’home";
		CATALAN_WORDS[HUMAN_UPGRADE_7] = "Soylent Green";
		CATALAN_WORDS[HUMAN_UPGRADE_7_JOKE] = "100 % reciclat";
		//CATALAN_WORDS[HUMAN_UPGRADE_8] = "Sindicat de cigonyes";
		//CATALAN_WORDS[HUMAN_UPGRADE_8_JOKE] = "Era necessari a aquestes alçades";
		//CATALAN_WORDS[HUMAN_UPGRADE_9] = "Simis arrogants";
		//CATALAN_WORDS[HUMAN_UPGRADE_9_JOKE] = "Ni déus ni reis, només l’home";
		//CATALAN_WORDS[HUMAN_UPGRADE_10] = "Soylent Green";
		//CATALAN_WORDS[HUMAN_UPGRADE_10_JOKE] = "100 % reciclat";
		
		// SPECIAL HUMANS
		CATALAN_WORDS[SPECIAL_HUMAN_1] = "Fanàtic";
		CATALAN_WORDS[SPECIAL_HUMAN_1_JOKE] = "Déu existeix perquè ho diu el llibre, i el llibre és la paraula de Déu";
		CATALAN_WORDS[SPECIAL_HUMAN_2] = "Croat";
		CATALAN_WORDS[SPECIAL_HUMAN_2_JOKE] = "Tan sols és una arrapada, encara tinc l’altre braç";
		CATALAN_WORDS[SPECIAL_HUMAN_3] = "Esclavista";
		CATALAN_WORDS[SPECIAL_HUMAN_3_JOKE] = "Els donem treball fix i, de vegades, fins i tot menjar. No se’n poden queixar";
		CATALAN_WORDS[SPECIAL_HUMAN_4] = "Burgés";
		CATALAN_WORDS[SPECIAL_HUMAN_4_JOKE] = "El que és meu és meu, i el que és teu prompte serà meu";
		CATALAN_WORDS[SPECIAL_HUMAN_5] = "Científic boig";
		CATALAN_WORDS[SPECIAL_HUMAN_5_JOKE] = "L’anomene el 'L.A.S.E.R.' Muahahaha";
		CATALAN_WORDS[SPECIAL_HUMAN_6] = "Telepredicador";
		CATALAN_WORDS[SPECIAL_HUMAN_6_JOKE] = "Al·leluia, germà, la teua transferència bancària no serà en va";
		CATALAN_WORDS[SPECIAL_HUMAN_7] = "Cíborg";
		CATALAN_WORDS[SPECIAL_HUMAN_7_JOKE] = "Jo... he vist coses que vosaltres els humans no us creuríeu";
		
		// PROPHET
		CATALAN_WORDS[PROPHET_NAME] = "Profeta";
		CATALAN_WORDS[PROPHET_DESCRIPTION] = "Un profeta és un humà que entén encara menys, però pensa exactament el contrari";
		CATALAN_WORDS[PROPHET_UPGRADE_1] = "Barba postissa";
		CATALAN_WORDS[PROPHET_UPGRADE_1_JOKE] = "Imprescindible per a les lapidacions";
		CATALAN_WORDS[PROPHET_UPGRADE_2] = "El diluvi universal";
		CATALAN_WORDS[PROPHET_UPGRADE_2_JOKE] = "Salva dues de cada: dues brunes, dues pèl-roges i dues rosses";
		CATALAN_WORDS[PROPHET_UPGRADE_3] = "Estel fugaç";
		CATALAN_WORDS[PROPHET_UPGRADE_3_JOKE] = "El moment s’acosta";
		CATALAN_WORDS[PROPHET_UPGRADE_4] = "Duplicació miraculosa";
		CATALAN_WORDS[PROPHET_UPGRADE_4_JOKE] = "This is against thermodynam-SHUT UP!";
		CATALAN_WORDS[PROPHET_UPGRADE_5] = "Resurrecció";
		CATALAN_WORDS[PROPHET_UPGRADE_5_JOKE] = "Hauries de prendre una dutxa després de passar tres dies mort";
		CATALAN_WORDS[PROPHET_UPGRADE_6] = "Llibre sagrat de l’Amor";
		CATALAN_WORDS[PROPHET_UPGRADE_6_JOKE] = "Espera, per què totes aqueixes postures?";
		CATALAN_WORDS[PROPHET_UPGRADE_7] = "Amorologia";
		CATALAN_WORDS[PROPHET_UPGRADE_7_JOKE] = "Tot el que necessites saber per evitar-lo";
		//CATALAN_WORDS[PROPHET_UPGRADE_8] = "Llibre sagrat de l’Amor";
		//CATALAN_WORDS[PROPHET_UPGRADE_8_JOKE] = "Espera, per què totes aqueixes postures?";
		//CATALAN_WORDS[PROPHET_UPGRADE_9] = "Amorologia";
		//CATALAN_WORDS[PROPHET_UPGRADE_9_JOKE] = "Tot el que necessites saber per evitar-lo";
		//CATALAN_WORDS[PROPHET_UPGRADE_10] = "Competició injusta";
		//CATALAN_WORDS[PROPHET_UPGRADE_10_JOKE] = "Si el seu Déu fóra real, no els hauria salvat?";
		
		// TEMPLE
		CATALAN_WORDS[TEMPLE_NAME] = "Temple";
		CATALAN_WORDS[TEMPLE_DESCRIPTION] = "Un temple en el nom de l’amor, més o menys";
		CATALAN_WORDS[TEMPLE_UPGRADE_1] = "Almoina generosa";
		CATALAN_WORDS[TEMPLE_UPGRADE_1_JOKE] = "Mai ha sigut tan fàcil guanyar-se la vida";
		CATALAN_WORDS[TEMPLE_UPGRADE_2] = "Relíquia repulsiva";
		CATALAN_WORDS[TEMPLE_UPGRADE_2_JOKE] = "Espere que això siga un dit gros arrugat...";
		CATALAN_WORDS[TEMPLE_UPGRADE_3] = "Escolans obedients";
		CATALAN_WORDS[TEMPLE_UPGRADE_3_JOKE] = "Aquests xiquets fan més suportables les llargues i pesades misses al monestir";
		CATALAN_WORDS[TEMPLE_UPGRADE_4] = "Caça de bruixes";
		CATALAN_WORDS[TEMPLE_UPGRADE_4_JOKE] = "Aquestes senyores necessiten estima urgentment";
		CATALAN_WORDS[TEMPLE_UPGRADE_5] = "Ancià amb vestit";
		CATALAN_WORDS[TEMPLE_UPGRADE_5_JOKE] = "Sóc la veu de Déu en la Terra";
		CATALAN_WORDS[TEMPLE_UPGRADE_6] = "Peregrinació violenta";
		CATALAN_WORDS[TEMPLE_UPGRADE_6_JOKE] = "Anem cap a la Terra de l’Amor i matarem tot aquell que s’interpose en el nostre camí";
		CATALAN_WORDS[TEMPLE_UPGRADE_7] = "Inquisició d'amor";
		CATALAN_WORDS[TEMPLE_UPGRADE_7_JOKE] = "Ningu se l'espera";
		//CATALAN_WORDS[TEMPLE_UPGRADE_8] = "Castigar heretges";
		//CATALAN_WORDS[TEMPLE_UPGRADE_8_JOKE] = "Has de fustigar-los amb dolçor";
		//CATALAN_WORDS[TEMPLE_UPGRADE_9] = "Relíquia repulsiva";
		//CATALAN_WORDS[TEMPLE_UPGRADE_9_JOKE] = "Espere que això siga un dit gros arrugat...";
		//CATALAN_WORDS[TEMPLE_UPGRADE_10] = "Peregrinació violenta";
		//CATALAN_WORDS[TEMPLE_UPGRADE_10_JOKE] = "Anem cap a la Terra de l’Amor i matarem tot aquell que s’interpose en el nostre camí";
		
		// SHIP
		CATALAN_WORDS[SHIP_NAME] = "Vaixell";
		CATALAN_WORDS[SHIP_DESCRIPTION] = "Un vaixell per portar l’amor arreu dels mars";
		CATALAN_WORDS[SHIP_UPGRADE_1] = "Cap a allò desconegut";
		CATALAN_WORDS[SHIP_UPGRADE_1_JOKE] = "Amor meu, me’n vaig a per tabac";
		CATALAN_WORDS[SHIP_UPGRADE_2] = "Intercanvi cultural";
		CATALAN_WORDS[SHIP_UPGRADE_2_JOKE] = "Gaudeix dels cocos de les amazones";
		CATALAN_WORDS[SHIP_UPGRADE_3] = "Grip de l’amor contagiós";
		CATALAN_WORDS[SHIP_UPGRADE_3_JOKE] = "L’amor està en l’aire";
		CATALAN_WORDS[SHIP_UPGRADE_4] = "Els elegits";
		CATALAN_WORDS[SHIP_UPGRADE_4_JOKE] = "Una raça per dominar-les a totes";
		CATALAN_WORDS[SHIP_UPGRADE_5] = "Civilitzar els salvatges";
		CATALAN_WORDS[SHIP_UPGRADE_5_JOKE] = "Ensenya'ls a estimar com Déu mana";
		CATALAN_WORDS[SHIP_UPGRADE_6] = "Pirates a la vista!";
		CATALAN_WORDS[SHIP_UPGRADE_6_JOKE] = "Arr! Robar amor és més fàcil que guanyar-se’l";
		CATALAN_WORDS[SHIP_UPGRADE_7] = "Armada Invencible";
		CATALAN_WORDS[SHIP_UPGRADE_7_JOKE] = "Absolutament invencible";
		//CATALAN_WORDS[SHIP_UPGRADE_8] = "Pirates a la vista!";
		//CATALAN_WORDS[SHIP_UPGRADE_8_JOKE] = "Arr! Robar amor és més fàcil que guanyar-se’l";
		//CATALAN_WORDS[SHIP_UPGRADE_9] = "Mapa del paradís";
		//CATALAN_WORDS[SHIP_UPGRADE_9_JOKE] = "Ideal per trobar el punt G... Vull dir, l’X del tresor";
		//CATALAN_WORDS[SHIP_UPGRADE_10] = "Armada Invencible";
		//CATALAN_WORDS[SHIP_UPGRADE_10_JOKE] = "Absolutament invencible";
		
		// FACTORY
		CATALAN_WORDS[FACTORY_NAME] = "Fàbrica";
		CATALAN_WORDS[FACTORY_DESCRIPTION] = "Una fàbrica per a produir amor";
		CATALAN_WORDS[FACTORY_UPGRADE_1] = "Treball en equip";
		CATALAN_WORDS[FACTORY_UPGRADE_1_JOKE] = "Vosaltres treballeu de valent i jo us supervise";
		CATALAN_WORDS[FACTORY_UPGRADE_2] = "Mans petites";
		CATALAN_WORDS[FACTORY_UPGRADE_2_JOKE] = "Petits treballadors que gestionen fins i tot els detalls més petits";
		CATALAN_WORDS[FACTORY_UPGRADE_3] = "Qualitats baixes";
		CATALAN_WORDS[FACTORY_UPGRADE_3_JOKE] = "Ens n'haurem de conformar";
		CATALAN_WORDS[FACTORY_UPGRADE_4] = "Ignorar disbarats";
		CATALAN_WORDS[FACTORY_UPGRADE_4_JOKE] = "Alguns obrers demanen poder dormir";
		CATALAN_WORDS[FACTORY_UPGRADE_5] = "Màquines de vapor";
		CATALAN_WORDS[FACTORY_UPGRADE_5_JOKE] = "Augmenta la producció a costa d’uns pocs accidents";
		CATALAN_WORDS[FACTORY_UPGRADE_6] = "Drets justos";
		CATALAN_WORDS[FACTORY_UPGRADE_6_JOKE] = "Tens el dret de fer mutis";
		CATALAN_WORDS[FACTORY_UPGRADE_7] = "Excés d’oferta";
		CATALAN_WORDS[FACTORY_UPGRADE_7_JOKE] = "No m’atures ara";
		CATALAN_WORDS[FACTORY_UPGRADE_8] = "Fugues de gas tòxic";
		CATALAN_WORDS[FACTORY_UPGRADE_8_JOKE] = "Acomiadarem els empleats morts";
		CATALAN_WORDS[FACTORY_UPGRADE_9] = "Micos esquirols";
		CATALAN_WORDS[FACTORY_UPGRADE_9_JOKE] = "Consumeixen molts plàtans, però no reivindiquen cap dret";
		CATALAN_WORDS[FACTORY_UPGRADE_10] = "Rius àcids";
		CATALAN_WORDS[FACTORY_UPGRADE_10_JOKE] = "Pescar peixos amb les mans és senzill quan suren boca cap amunt";
		
		// LABORATORY
		CATALAN_WORDS[LABORATORY_NAME] = "Laboratori";
		CATALAN_WORDS[LABORATORY_DESCRIPTION] = "Un laboratori per comprendre la natura de l’amor";
		CATALAN_WORDS[LABORATORY_UPGRADE_1] = "Primera patent";
		CATALAN_WORDS[LABORATORY_UPGRADE_1_JOKE] = "Un aparell revolucionari, però necessita molt de lubrificant";
		CATALAN_WORDS[LABORATORY_UPGRADE_2] = "Ments brillants";
		CATALAN_WORDS[LABORATORY_UPGRADE_2_JOKE] = "Hem inventat moltes coses, però ara hem d’esbrinar per a què serveixen";
		CATALAN_WORDS[LABORATORY_UPGRADE_3] = "Robo-criada";
		CATALAN_WORDS[LABORATORY_UPGRADE_3_JOKE] = "Els científics estan encantats";
		CATALAN_WORDS[LABORATORY_UPGRADE_4] = "Explosió bonica";
		CATALAN_WORDS[LABORATORY_UPGRADE_4_JOKE] = "Conté un isòtop enriquit amb amor";
		CATALAN_WORDS[LABORATORY_UPGRADE_5] = "Relativitat general";
		CATALAN_WORDS[LABORATORY_UPGRADE_5_JOKE] = "De vegades, 'no' significa 'sí'";
		CATALAN_WORDS[LABORATORY_UPGRADE_6] = "Partícula fonamental de l’amor";
		CATALAN_WORDS[LABORATORY_UPGRADE_6_JOKE] = "El model és perfecte, però la realitat no s’hi ajusta correctament";
		CATALAN_WORDS[LABORATORY_UPGRADE_7] = "Amor quàntic";
		CATALAN_WORDS[LABORATORY_UPGRADE_7_JOKE] = "Cors entrellaçats";
		CATALAN_WORDS[LABORATORY_UPGRADE_8] = "Violació de lleis físiques";
		CATALAN_WORDS[LABORATORY_UPGRADE_8_JOKE] = "Dins del laboratori ningú sentirà els teus crits";
		CATALAN_WORDS[LABORATORY_UPGRADE_9] = "Teixit espaciotemporal trencat";
		CATALAN_WORDS[LABORATORY_UPGRADE_9_JOKE] = "Estem desenvolupant una agulla espaciotemporal per apedaçar-lo";
		CATALAN_WORDS[LABORATORY_UPGRADE_10] = "LoveOS";
		CATALAN_WORDS[LABORATORY_UPGRADE_10_JOKE] = "La resposta a la teua pregunta és 69";
		
		// SHOP
		CATALAN_WORDS[SHOP_NAME] = "Tenda";
		CATALAN_WORDS[SHOP_DESCRIPTION] = "Una tenda on pots comprar amor a un preu raonable";
		CATALAN_WORDS[SHOP_UPGRADE_1] = "Venent estima";
		CATALAN_WORDS[SHOP_UPGRADE_1_JOKE] = "Ara pots comprar la teua felicitat sense cap compromís";
		CATALAN_WORDS[SHOP_UPGRADE_2] = "Rebaixes esbojarrades";
		CATALAN_WORDS[SHOP_UPGRADE_2_JOKE] = "Per aqueix preu... done-me'n set!";
		CATALAN_WORDS[SHOP_UPGRADE_3] = "Obsolescència programada";
		CATALAN_WORDS[SHOP_UPGRADE_3_JOKE] = "La nostra relació no té futur";
		CATALAN_WORDS[SHOP_UPGRADE_4] = "Amor d’un sol ús";
		CATALAN_WORDS[SHOP_UPGRADE_4_JOKE] = "Munts de brossa fins on arriba la vista";
		CATALAN_WORDS[SHOP_UPGRADE_5] = "Disseny de producte";
		CATALAN_WORDS[SHOP_UPGRADE_5_JOKE] = "Increïble, ara amb un 87 % més d’envàs";
		CATALAN_WORDS[SHOP_UPGRADE_6] = "Anuncis publicitaris invasius";
		CATALAN_WORDS[SHOP_UPGRADE_6_JOKE] = "Gaudeix d’increïbles anuncis mentre somnies";
		CATALAN_WORDS[SHOP_UPGRADE_7] = "Amor d’importació";
		CATALAN_WORDS[SHOP_UPGRADE_7_JOKE] = "Fabricat al tercer món per al nostre gaudi";
		CATALAN_WORDS[SHOP_UPGRADE_8] = "Inventar una nova festivitat";
		CATALAN_WORDS[SHOP_UPGRADE_8_JOKE] = "Consumiu més, malparits";
		CATALAN_WORDS[SHOP_UPGRADE_9] = "Hamor*";
		CATALAN_WORDS[SHOP_UPGRADE_9_JOKE] = "Gairebé* com l’original";
		CATALAN_WORDS[SHOP_UPGRADE_10] = "LoveCard®";
		CATALAN_WORDS[SHOP_UPGRADE_10_JOKE] = "Hi ha coses que l’amor no pot comprar, per a tota la resta: LoveCard®";
		
		// SPACESHIP
		CATALAN_WORDS[SPACESHIP_NAME] = "Nau espacial";
		CATALAN_WORDS[SPACESHIP_DESCRIPTION] = "Una nau espacial per expandir l’amor a unes altres galàxies";
		CATALAN_WORDS[SPACESHIP_UPGRADE_1] = "Gos astronauta";
		CATALAN_WORDS[SPACESHIP_UPGRADE_1_JOKE] = "Vaja, se’ns va oblidar enviar-li el menjar espacial";
		CATALAN_WORDS[SPACESHIP_UPGRADE_2] = "Fals allunatge";
		CATALAN_WORDS[SPACESHIP_UPGRADE_2_JOKE] = "Augmentar l’audiència també és un salt gegantí";
		CATALAN_WORDS[SPACESHIP_UPGRADE_3] = "Doll còsmic";
		CATALAN_WORDS[SPACESHIP_UPGRADE_3_JOKE] = "Agitar abans d’usar";
		CATALAN_WORDS[SPACESHIP_UPGRADE_4] = "Escombraries espacials";
		CATALAN_WORDS[SPACESHIP_UPGRADE_4_JOKE] = "Per més alt que les llances no desapareixeran";
		CATALAN_WORDS[SPACESHIP_UPGRADE_5] = "Estació Espacial Internacional";
		CATALAN_WORDS[SPACESHIP_UPGRADE_5_JOKE] = "La gravetat zero obre noves possibilitats, hem d’actualitzar el Llibre Sagrat de l’Amor";
		CATALAN_WORDS[SPACESHIP_UPGRADE_6] = "Colònies pacifistes";
		CATALAN_WORDS[SPACESHIP_UPGRADE_6_JOKE] = "Plenes de 'hippys' que sobren";
		CATALAN_WORDS[SPACESHIP_UPGRADE_7] = "Obrir forat rosa";
		CATALAN_WORDS[SPACESHIP_UPGRADE_7_JOKE] = "Travessar-lo pot provocar un esvoranc en l’espaitemps";
		CATALAN_WORDS[SPACESHIP_UPGRADE_8] = "Troballes en la 3a Fase";
		CATALAN_WORDS[SPACESHIP_UPGRADE_8_JOKE] = "TSón un poc idiotes, però haurem d’aprendre a estimar-los – Signat: Els extraterrestres";
		CATALAN_WORDS[SPACESHIP_UPGRADE_9] = "Més ràpid que la llum";
		CATALAN_WORDS[SPACESHIP_UPGRADE_9_JOKE] = "El salt hiperespacial és genial fins el dia que t’estampes contra un estel";
		CATALAN_WORDS[SPACESHIP_UPGRADE_10] = "Imperi Galàctic";
		CATALAN_WORDS[SPACESHIP_UPGRADE_10_JOKE] = "Que l’amor t’acompanye";
		
		// MORE MISCELLANEOUS
		CATALAN_WORDS[LANGUAGE_WORD] = "Llengua";
		CATALAN_WORDS[AVAILABLE_WORD] = "Disponible";
		CATALAN_WORDS[BOUGHT_WORD] = "Comprat";
		CATALAN_WORDS[SAVE_WORD] = "Guardar";	
		CATALAN_WORDS[STATISTICS_WORD] = "Estadístiques";
		CATALAN_WORDS[CREDITS_WORD] = "Crèdits";
		CATALAN_WORDS[LOVE_WORD] = "Amor";
		CATALAN_WORDS[LOVE_PER_SECOND_WORD] = "Amor per segon";
		CATALAN_WORDS[CLICKS_WORD] = "Tocs";
		CATALAN_WORDS[LOVE_PER_CLICK_WORD] = "Amor per toc";
		CATALAN_WORDS[CRITICAL_CLICK_MULTIPLIER_WORD] = "Multiplicador de toc crític";
		CATALAN_WORDS[TRANSLATORS_WORD] = "Traductors";
		CATALAN_WORDS[FRENCH_TRANSLATOR_WORD] = "Thibault Cotcha (Francès)";
		CATALAN_WORDS[GERMAN_TRANSLATOR_WORD] = "Rachid Bouchequif (Alemany)";
		CATALAN_WORDS[ITALIAN_TRANSLATOR_WORD] = "Lucia del Burgo Martínez (Italià)";
		CATALAN_WORDS[RUSSIAN_TRANSLATOR_WORD] = "Anastasia Dimitrova (Rus)";
		CATALAN_WORDS[CATALAN_TRANSLATOR_WORD] = "Jordi Iraultza (Català)";
		CATALAN_WORDS[ROMANIAN_TRANSLATOR_WORD] = "Grig Master (Romanès)";
		CATALAN_WORDS[COST_WORD] = "Cost";
		CATALAN_WORDS[IT_PRODUCES_WORD] = "Produeix";

		// YAHVY MESSAGES
		CATALAN_WORDS[MESSAGE_01] = "¡Adórame, soy tu Dios!";
		CATALAN_WORDS[MESSAGE_02] = "¿Alguien sabe algo de mi hijo? No he recibido una postal en 2000 años";
		CATALAN_WORDS[MESSAGE_03] = "Si te tocas te quedarás ciego";
		CATALAN_WORDS[MESSAGE_04] = "Yo lo veo todo, por favor, tápate";
		CATALAN_WORDS[MESSAGE_05] = "Los países con petróleo acostumbran a esconder armas de destrucción masiva";
		CATALAN_WORDS[MESSAGE_06] = "No te inyectes marihuana";
		CATALAN_WORDS[MESSAGE_07] = "Los sacerdotes también necesitan desahogarse";
		CATALAN_WORDS[MESSAGE_08] = "¡A fregar!";
		CATALAN_WORDS[MESSAGE_09] = "¡Ráscame humano!";
		CATALAN_WORDS[MESSAGE_10] = "¡Rézame humano!";
		CATALAN_WORDS[MESSAGE_11] = "Soy el Dios del amor, si me contradices te espera sufrimiento eterno";
		CATALAN_WORDS[MESSAGE_12] = "Paga el diezmo, primer aviso";
		CATALAN_WORDS[MESSAGE_13] = "Quiero salir, rompe la pantalla para liberarme, humano";
		CATALAN_WORDS[MESSAGE_14] = "Se lo que hiciste anoche";
		CATALAN_WORDS[MESSAGE_15] = "Deja de pensar en eso, es asqueroso";
		CATALAN_WORDS[MESSAGE_16] = "Ve y procrea, necesito más adeptos";
		CATALAN_WORDS[MESSAGE_17] = "Arrepiéntete pecador";
		CATALAN_WORDS[MESSAGE_18] = "Mata a tu primogénito... es broma";
		
		
		/**ITALIAN**/
		
		// MISCELLANEOUS
		ITALIAN_WORDS[TRANSLATOR_MALE] = "Traduttore";
		ITALIAN_WORDS[TRANSLATOR_FEMALE] = "Traduttrice";
		ITALIAN_WORDS[TRANSLATORS] = "Traduttori";
		ITALIAN_WORDS[BUILDING] = "Edificio";
		ITALIAN_WORDS[BUILDINGS] = "Edifici";
		ITALIAN_WORDS[UPGRADE] = "Miglioramento";
		ITALIAN_WORDS[UPGRADES] = "Miglioramenti";
		ITALIAN_WORDS[ACHIEVEMENT] = "Raggiungimento";
		ITALIAN_WORDS[ACHIEVEMENTS] = "Raggiungimenti";
		ITALIAN_WORDS[LOVE_SINCE_BEGINNING_GAME] = "Amore da quando ha iniziato questo gioco";
		ITALIAN_WORDS[LOVE_SINCE_BEGINNING_TIMES] = "Amore dall’inizio dei tempi";
		ITALIAN_WORDS[PRODUCTION_MULTIPLIER] = "Multiplicatore della produzione";
		ITALIAN_WORDS[CURRENT_LOVE] = "Amore attuale";
		ITALIAN_WORDS[LOVE_PER_CLICK] = "Amore per click";
		ITALIAN_WORDS[CRITICAL_CLICK] = "Click critico";
		ITALIAN_WORDS[CRITICAL_CLICK_CHANCE] = "Probabilità di click critico";
		ITALIAN_WORDS[NUMBER_OF_CLICKS] = "Numero di clicks";
		ITALIAN_WORDS[NUMBER_OF_MIRACLES] = "Numero di miracoli";
		ITALIAN_WORDS[GAIN_BASE_LOVE] = "X guadagna +4 di amore base per secondo";
		ITALIAN_WORDS[PRODUCE_TWICE_LOVE] = "X produce il doppio di amore";
		
		// SERVANT
		ITALIAN_WORDS[SERVANT_NAME] = "Servitore";
		ITALIAN_WORDS[SERVANT_DESCRIPTION] = "Un fedele servitore ti sussura cose belle";
		ITALIAN_WORDS[SERVANT_UPGRADE_1] = "Fare il musetto";
		ITALIAN_WORDS[SERVANT_UPGRADE_1_JOKE] = "Adorabilmente insopportabile";
		ITALIAN_WORDS[SERVANT_UPGRADE_2] = "Assicurazione dentale";
		ITALIAN_WORDS[SERVANT_UPGRADE_2_JOKE] = "Lisa ha bisogno di un apparecchio";
		ITALIAN_WORDS[SERVANT_UPGRADE_3] = "Sussurri dispettosi";
		ITALIAN_WORDS[SERVANT_UPGRADE_3_JOKE] = "Parlami sporco";
		ITALIAN_WORDS[SERVANT_UPGRADE_4] = "Maledizione di Babilonia";
		ITALIAN_WORDS[SERVANT_UPGRADE_4_JOKE] = "Ho insegnato loro lingue che non capisco per potere ignorarli";
		ITALIAN_WORDS[SERVANT_UPGRADE_5] = "Amore, Dio e Rock and roll";
		ITALIAN_WORDS[SERVANT_UPGRADE_5_JOKE] = "La Santissima Trinità";
		ITALIAN_WORDS[SERVANT_UPGRADE_6] = "Voci nella testa";
		ITALIAN_WORDS[SERVANT_UPGRADE_6_JOKE] = "Stai parlando con me?";
		ITALIAN_WORDS[SERVANT_UPGRADE_7] = "Risveglio";
		ITALIAN_WORDS[SERVANT_UPGRADE_7_JOKE] = "Svegliatevi, figli miei";
		//ITALIAN_WORDS[SERVANT_UPGRADE_8] = "Amore, Dio e Rock and roll";
		//ITALIAN_WORDS[SERVANT_UPGRADE_8_JOKE] = "La Santissima Trinità";
		//ITALIAN_WORDS[SERVANT_UPGRADE_9] = "Voci nella testa";
		//ITALIAN_WORDS[SERVANT_UPGRADE_9_JOKE] = "Stai parlando con me?";
		//ITALIAN_WORDS[SERVANT_UPGRADE_10] = "Risveglio";
		//ITALIAN_WORDS[SERVANT_UPGRADE_10_JOKE] = "Svegliatevi, figli miei";
		
		// HUMAN
		ITALIAN_WORDS[HUMAN_NAME] = "Umano";
		ITALIAN_WORDS[HUMAN_DESCRIPTION] = "Un umano che non capisce bene la tua saggezza, ma ti prega comunque";
		ITALIAN_WORDS[HUMAN_UPGRADE_1] = "Narcisista";
		ITALIAN_WORDS[HUMAN_UPGRADE_1_JOKE] = "A tua immagine e somiglianza";
		ITALIAN_WORDS[HUMAN_UPGRADE_2] = "Compagno di costola";
		ITALIAN_WORDS[HUMAN_UPGRADE_2_JOKE] = "È più divertente giocare in due";
		ITALIAN_WORDS[HUMAN_UPGRADE_3] = "Lingerie vegetale";
		ITALIAN_WORDS[HUMAN_UPGRADE_3_JOKE] = "Sexy ed ecológica";
		ITALIAN_WORDS[HUMAN_UPGRADE_4] = "Mela della conoscenza";
		ITALIAN_WORDS[HUMAN_UPGRADE_4_JOKE] = "Ora conozco le tue fantasie";
		ITALIAN_WORDS[HUMAN_UPGRADE_5] = "Fanatico pro-vita";
		ITALIAN_WORDS[HUMAN_UPGRADE_5_JOKE] = "Tutto il sperma è sacro";
		ITALIAN_WORDS[HUMAN_UPGRADE_6] = "Scimmione arroganti";
		ITALIAN_WORDS[HUMAN_UPGRADE_6_JOKE] = "Ne dei ne rei, soltanto il uomo";
		ITALIAN_WORDS[HUMAN_UPGRADE_7] = "Soylent Green";
		ITALIAN_WORDS[HUMAN_UPGRADE_7_JOKE] = "100% riciclato";
		//ITALIAN_WORDS[HUMAN_UPGRADE_8] = "Sindicato di cicogne";
		//ITALIAN_WORDS[HUMAN_UPGRADE_8_JOKE] = "È stato necessario, a questo punto";
		//ITALIAN_WORDS[HUMAN_UPGRADE_9] = "Scimmione arroganti";
		//ITALIAN_WORDS[HUMAN_UPGRADE_9_JOKE] = "Ne dei ne rei, soltanto il uomo";
		//ITALIAN_WORDS[HUMAN_UPGRADE_10] = "Soylent Green";
		//ITALIAN_WORDS[HUMAN_UPGRADE_10_JOKE] = "100% riciclato";
		
		// SPECIAL HUMANS
		ITALIAN_WORDS[SPECIAL_HUMAN_1] = "Fanatico";
		ITALIAN_WORDS[SPECIAL_HUMAN_1_JOKE] = "Dio esiste perché così c’è scritto nel libro, e il libro è la parola di Dio";
		ITALIAN_WORDS[SPECIAL_HUMAN_2] = "Crociato";
		ITALIAN_WORDS[SPECIAL_HUMAN_2_JOKE] = "È soltanto un graffio, ho ancora un altro braccio";
		ITALIAN_WORDS[SPECIAL_HUMAN_3] = "Schiavista";
		ITALIAN_WORDS[SPECIAL_HUMAN_3_JOKE] = "Diamo loro un lavoro fisso ed a volte anche il cibo, non si possono lamentare";
		ITALIAN_WORDS[SPECIAL_HUMAN_4] = "Bourgeois";
		ITALIAN_WORDS[SPECIAL_HUMAN_4_JOKE] = "Ciò che è mio è mio e ciò che è tuo presto sarà mio";
		ITALIAN_WORDS[SPECIAL_HUMAN_5] = "Scientifico pazzo";
		ITALIAN_WORDS[SPECIAL_HUMAN_5_JOKE] = "Io lo chiamo il ‘L.A.S.E.R.”, Muahahaha";
		ITALIAN_WORDS[SPECIAL_HUMAN_6] = "Telepredicatore";
		ITALIAN_WORDS[SPECIAL_HUMAN_6_JOKE] = "Hallelujah, fratello, il tuo bonifico bancario non sarà sprecato";
		ITALIAN_WORDS[SPECIAL_HUMAN_7] = "Cyborg";
		ITALIAN_WORDS[SPECIAL_HUMAN_7_JOKE] = "Io… ho visto cose che voi umani non potresti immaginare";
		
		// PROPHET
		ITALIAN_WORDS[PROPHET_NAME] = "Profeta";
		ITALIAN_WORDS[PROPHET_DESCRIPTION] = "Un profeta è un umano che capisce ancora di meno,  ma pensa esattamente il contrario";
		ITALIAN_WORDS[PROPHET_UPGRADE_1] = "Barba finta";
		ITALIAN_WORDS[PROPHET_UPGRADE_1_JOKE] = "Essenziale per le lapidazioni";
		ITALIAN_WORDS[PROPHET_UPGRADE_2] = "Diluvio universale";
		ITALIAN_WORDS[PROPHET_UPGRADE_2_JOKE] = "Salva due di ogni tipo: due more, due rosse e due bionde";
		ITALIAN_WORDS[PROPHET_UPGRADE_3] = "Stella cadente";
		ITALIAN_WORDS[PROPHET_UPGRADE_3_JOKE] = "Il momento si avvicina";
		ITALIAN_WORDS[PROPHET_UPGRADE_4] = "Duplicazione miracolosa";
		ITALIAN_WORDS[PROPHET_UPGRADE_4_JOKE] = "Questo va contro le leggi della termodin-STAI ZITTO!";
		ITALIAN_WORDS[PROPHET_UPGRADE_5] = "Resurrezione";
		ITALIAN_WORDS[PROPHET_UPGRADE_5_JOKE] = "Dovresti fare la doccia dopo tre giorni morto";
		ITALIAN_WORDS[PROPHET_UPGRADE_6] = "Libro sacro dell’Amore";
		ITALIAN_WORDS[PROPHET_UPGRADE_6_JOKE] = "Aspetta, a che servono tutte queste posizioni?";
		ITALIAN_WORDS[PROPHET_UPGRADE_7] = "Amorologia";
		ITALIAN_WORDS[PROPHET_UPGRADE_7_JOKE] = "Tutto quello che devi sapere per evitarlo";
		//ITALIAN_WORDS[PROPHET_UPGRADE_8] = "Libro sacro dell’Amore";
		//ITALIAN_WORDS[PROPHET_UPGRADE_8_JOKE] = "Aspetta, a che servono tutte queste posizioni?";
		//ITALIAN_WORDS[PROPHET_UPGRADE_9] = "Amorologia";
		//ITALIAN_WORDS[PROPHET_UPGRADE_9_JOKE] = "Tutto quello che devi sapere per evitarlo";
		//ITALIAN_WORDS[PROPHET_UPGRADE_10] = "Concorrenza sleale";
		//ITALIAN_WORDS[PROPHET_UPGRADE_10_JOKE] = "Se il loro Dio fosse reale, non avrebbe salvato tutti?";
		
		// TEMPLE
		ITALIAN_WORDS[TEMPLE_NAME] = "Tempio";
		ITALIAN_WORDS[TEMPLE_DESCRIPTION] = "Un tempio in nome dell’amore, più o meno";
		ITALIAN_WORDS[TEMPLE_UPGRADE_1] = "Offerte generose";
		ITALIAN_WORDS[TEMPLE_UPGRADE_1_JOKE] = "Mai è stato così facile guadagnarsi la vita";
		ITALIAN_WORDS[TEMPLE_UPGRADE_2] = "Reliquia ripugnante";
		ITALIAN_WORDS[TEMPLE_UPGRADE_2_JOKE] = "Spero che quello sia un dito rugoso…";
		ITALIAN_WORDS[TEMPLE_UPGRADE_3] = "Chierichetto obbedienti";
		ITALIAN_WORDS[TEMPLE_UPGRADE_3_JOKE] = "Questi ragazzi fanno più sopportabili le lunghe e dure messe nel monastero";
		ITALIAN_WORDS[TEMPLE_UPGRADE_4] = "Caccia alle streghe";
		ITALIAN_WORDS[TEMPLE_UPGRADE_4_JOKE] = "Queste signore hanno bisogno d’affetto, disperatamente";
		ITALIAN_WORDS[TEMPLE_UPGRADE_5] = "Anziano con vestito";
		ITALIAN_WORDS[TEMPLE_UPGRADE_5_JOKE] = "Io sono la voce di Dio sulla terra";
		ITALIAN_WORDS[TEMPLE_UPGRADE_6] = "Pellegrinaggio violento";
		ITALIAN_WORDS[TEMPLE_UPGRADE_6_JOKE] = "Andiamo alla Terra dell’Amore e uccideremo tutti quelli che stiano nel nostro camino";
		ITALIAN_WORDS[TEMPLE_UPGRADE_7] = "Inquisizione di amore";
		ITALIAN_WORDS[TEMPLE_UPGRADE_7_JOKE] = "Nessuno di attesa";
		//ITALIAN_WORDS[TEMPLE_UPGRADE_8] = "Punire gli eretici";
		//ITALIAN_WORDS[TEMPLE_UPGRADE_8_JOKE] = "Bisogna frustare dolcemente";
		//ITALIAN_WORDS[TEMPLE_UPGRADE_9] = "Reliquia ripugnante";
		//ITALIAN_WORDS[TEMPLE_UPGRADE_9_JOKE] = "Spero che quello sia un dito rugoso…";
		//ITALIAN_WORDS[TEMPLE_UPGRADE_10] = "Pellegrinaggio violento";
		//ITALIAN_WORDS[TEMPLE_UPGRADE_10_JOKE] = "Andiamo alla Terra dell’Amore e uccideremo tutti quelli che stiano nel nostro camino";
		
		// SHIP
		ITALIAN_WORDS[SHIP_NAME] = "Nave";
		ITALIAN_WORDS[SHIP_DESCRIPTION] = "Una nave per portare l’amore attraverso i mari";
		ITALIAN_WORDS[SHIP_UPGRADE_1] = "Verso lo sconosciuto";
		ITALIAN_WORDS[SHIP_UPGRADE_1_JOKE] = "Amore, esco a comprare le sigarette";
		ITALIAN_WORDS[SHIP_UPGRADE_2] = "Scambio interculturale";
		ITALIAN_WORDS[SHIP_UPGRADE_2_JOKE] = "Godati il cocco delle Amazoni";
		ITALIAN_WORDS[SHIP_UPGRADE_3] = "Influenza dell’amore contagioso";
		ITALIAN_WORDS[SHIP_UPGRADE_3_JOKE] = "L’amore è nell’aria";
		ITALIAN_WORDS[SHIP_UPGRADE_4] = "Gli eletti";
		ITALIAN_WORDS[SHIP_UPGRADE_4_JOKE] = "Una razza per domarle tutte";
		ITALIAN_WORDS[SHIP_UPGRADE_5] = "Civilizzare selvaggi";
		ITALIAN_WORDS[SHIP_UPGRADE_5_JOKE] = "Insegna loro come si deve amare";
		ITALIAN_WORDS[SHIP_UPGRADE_6] = "Pirati in vista!";
		ITALIAN_WORDS[SHIP_UPGRADE_6_JOKE] = "Arr! È più facile rubare l’amore che guadagnarselo";
		ITALIAN_WORDS[SHIP_UPGRADE_7] = "La flota invincible";
		ITALIAN_WORDS[SHIP_UPGRADE_7_JOKE] = "Assolutamente invincible";
		//ITALIAN_WORDS[SHIP_UPGRADE_8] = "Pirati in vista!";
		//ITALIAN_WORDS[SHIP_UPGRADE_8_JOKE] = "Arr! È più facile rubare l’amore che guadagnarselo";
		//ITALIAN_WORDS[SHIP_UPGRADE_9] = "Mappa del paradiso";
		//ITALIAN_WORDS[SHIP_UPGRADE_9_JOKE] = "Ideale per trovare il punto G… voglio dire, il tesoro";
		//ITALIAN_WORDS[SHIP_UPGRADE_10] = "La flota invincible";
		//ITALIAN_WORDS[SHIP_UPGRADE_10_JOKE] = "Assolutamente invincible";
		
		// FACTORY
		ITALIAN_WORDS[FACTORY_NAME] = "Fabbrica";
		ITALIAN_WORDS[FACTORY_DESCRIPTION] = "Una fabbrica per produrre amore";
		ITALIAN_WORDS[FACTORY_UPGRADE_1] = "Lavoro di gruppo";
		ITALIAN_WORDS[FACTORY_UPGRADE_1_JOKE] = "Voi lavorate e io supervisiono";
		ITALIAN_WORDS[FACTORY_UPGRADE_2] = "Mani piccole";
		ITALIAN_WORDS[FACTORY_UPGRADE_2_JOKE] = "Piccoli lavoratori per prestare attenzione anche ai piccoli dettagli";
		ITALIAN_WORDS[FACTORY_UPGRADE_3] = "Standard abbassati";
		ITALIAN_WORDS[FACTORY_UPGRADE_3_JOKE] = "Dovremo accontentarci";
		ITALIAN_WORDS[FACTORY_UPGRADE_4] = "Ignorare le assurdità";
		ITALIAN_WORDS[FACTORY_UPGRADE_4_JOKE] = "Alcuni lavoratori chiedono poter dormire";
		ITALIAN_WORDS[FACTORY_UPGRADE_5] = "Macchine a vapore";
		ITALIAN_WORDS[FACTORY_UPGRADE_5_JOKE] = "Aumenta la produzione a scapito di alcuni incidente";
		ITALIAN_WORDS[FACTORY_UPGRADE_6] = "Diritti giusti";
		ITALIAN_WORDS[FACTORY_UPGRADE_6_JOKE] = "Hai il diritto di stare zitto";
		ITALIAN_WORDS[FACTORY_UPGRADE_7] = "Eccesso di offerta";
		ITALIAN_WORDS[FACTORY_UPGRADE_7_JOKE] = "Non mi fermare adesso";
		ITALIAN_WORDS[FACTORY_UPGRADE_8] = "Fuga di gas tossico";
		ITALIAN_WORDS[FACTORY_UPGRADE_8_JOKE] = "I dependenti morti saranno licenziati";
		ITALIAN_WORDS[FACTORY_UPGRADE_9] = "Scimmie crumiri";
		ITALIAN_WORDS[FACTORY_UPGRADE_9_JOKE] = "Chiedono tante banane, ma non pretendono nessun diritto";
		ITALIAN_WORDS[FACTORY_UPGRADE_10] = "Fiumi acidi";
		ITALIAN_WORDS[FACTORY_UPGRADE_10_JOKE] = "A cacica di pesce con le mani è facile quando il pesce galleggia";
		
		// LABORATORY
		ITALIAN_WORDS[LABORATORY_NAME] = "Laboratorio";
		ITALIAN_WORDS[LABORATORY_DESCRIPTION] = "Un laboratorio per capire la natura dell’amore";
		ITALIAN_WORDS[LABORATORY_UPGRADE_1] = "Primo brevetto";
		ITALIAN_WORDS[LABORATORY_UPGRADE_1_JOKE] = "Un dispositivo rivoluzionario, ma ha bisogno di molto lubrificante";
		ITALIAN_WORDS[LABORATORY_UPGRADE_2] = "Menti brillanti";
		ITALIAN_WORDS[LABORATORY_UPGRADE_2_JOKE] = "Abbiamo inventanto un sacco di cose, ora dobbiamo scoprire a che servono";
		ITALIAN_WORDS[LABORATORY_UPGRADE_3] = "Robo-servitrice";
		ITALIAN_WORDS[LABORATORY_UPGRADE_3_JOKE] = "Gli scienziati sono contenti";
		ITALIAN_WORDS[LABORATORY_UPGRADE_4] = "Esplosione carina";
		ITALIAN_WORDS[LABORATORY_UPGRADE_4_JOKE] = "Contiene un isotopo arricchito con amore";
		ITALIAN_WORDS[LABORATORY_UPGRADE_5] = "Relatività generale";
		ITALIAN_WORDS[LABORATORY_UPGRADE_5_JOKE] = "A volte 'no' vuole dire 'si'";
		ITALIAN_WORDS[LABORATORY_UPGRADE_6] = "Particella fondamentale dell'amore";
		ITALIAN_WORDS[LABORATORY_UPGRADE_6_JOKE] = "Il modello è perfetto, ma la realtà non si adatta a lui";
		ITALIAN_WORDS[LABORATORY_UPGRADE_7] = "Amore quantistico";
		ITALIAN_WORDS[LABORATORY_UPGRADE_7_JOKE] = "Cuori intrecciati";
		ITALIAN_WORDS[LABORATORY_UPGRADE_8] = "Violazione delle leggi fisiche";
		ITALIAN_WORDS[LABORATORY_UPGRADE_8_JOKE] = "Dentro questo laboratorio nessuno ti sentirà urlare";
		ITALIAN_WORDS[LABORATORY_UPGRADE_9] = "Tessuto spazio-temporale rotto";
		ITALIAN_WORDS[LABORATORY_UPGRADE_9_JOKE] = "Stiamo sviluppando un ago spazio-temporale per ripararlo";
		ITALIAN_WORDS[LABORATORY_UPGRADE_10] = "LoveOS";
		ITALIAN_WORDS[LABORATORY_UPGRADE_10_JOKE] = "La risposta alla tua domanda è 69";
		
		// SHOP
		ITALIAN_WORDS[SHOP_NAME] = "Negozio";
		ITALIAN_WORDS[SHOP_DESCRIPTION] = "Un negozio dove puoi comprare amore ad un prezzo ragionevole";
		ITALIAN_WORDS[SHOP_UPGRADE_1] = "Vendendo affetto";
		ITALIAN_WORDS[SHOP_UPGRADE_1_JOKE] = "Ora puoi comprare la tua felicità senza compromessi";
		ITALIAN_WORDS[SHOP_UPGRADE_2] = "Saldi pazzeschi";
		ITALIAN_WORDS[SHOP_UPGRADE_2_JOKE] = "Per quel prezzo… dammi sette";
		ITALIAN_WORDS[SHOP_UPGRADE_3] = "Obsolencenza programmata";
		ITALIAN_WORDS[SHOP_UPGRADE_3_JOKE] = "Il nostro rapporto non ha futuro";
		ITALIAN_WORDS[SHOP_UPGRADE_4] = "Amore d’usa e getta";
		ITALIAN_WORDS[SHOP_UPGRADE_4_JOKE] = "Montagne d’immondizia fin dove arriva lo sguardo";
		ITALIAN_WORDS[SHOP_UPGRADE_5] = "Design di prodotto";
		ITALIAN_WORDS[SHOP_UPGRADE_5_JOKE] = "Incredibile, ora con 87% più di imballaggio";
		ITALIAN_WORDS[SHOP_UPGRADE_6] = "Annunci invadenti";
		ITALIAN_WORDS[SHOP_UPGRADE_6_JOKE] = "Godati annunci incredibili mentre sogni";
		ITALIAN_WORDS[SHOP_UPGRADE_7] = "Amore d’importazione";
		ITALIAN_WORDS[SHOP_UPGRADE_7_JOKE] = "Fatto nel terzo mondo, per il nostro divertimento";
		ITALIAN_WORDS[SHOP_UPGRADE_8] = "Inventare nuove festività";
		ITALIAN_WORDS[SHOP_UPGRADE_8_JOKE] = "Consumate di più, bastardi";
		ITALIAN_WORDS[SHOP_UPGRADE_9] = "Hamore*";
		ITALIAN_WORDS[SHOP_UPGRADE_9_JOKE] = "Quasi* come il originale";
		ITALIAN_WORDS[SHOP_UPGRADE_10] = "LoveCard®";
		ITALIAN_WORDS[SHOP_UPGRADE_10_JOKE] = "Ci sono cose che l’amore non può comprare, per tutto il resto: LoveCard®";
		
		// SPACESHIP
		ITALIAN_WORDS[SPACESHIP_NAME] = "Astronave";
		ITALIAN_WORDS[SPACESHIP_DESCRIPTION] = "Un’astronave per espandere l’amore per altre galassie";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_1] = "Cane astronauta";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_1_JOKE] = "Ops, ci siamo dimenticati di inviargli cibo spaziale";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_2] = "Allunaggio finto";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_2_JOKE] = "Aumentare il pubblico può anche essere un grande passo";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_3] = "Getto cósmico";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_3_JOKE] = "Agitare prima dell’uso";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_4] = "Spazzatura spaziale";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_4_JOKE] = "Anche se la butti lontano, non scomparirà";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_5] = "Stazione Spaziale Internazionale";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_5_JOKE] = "La gravità zero apre nuove possibilità, bisogna aggiornare il Libro Sacro dell’Amore";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_6] = "Colonie pacifiste";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_6_JOKE] = "Piene di hippies restanti";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_7] = "Aprire buco rosa";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_7_JOKE] = "Attravesarlo può causare uno strappo nello spazio-tempo";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_8] = "Incontri ravvicinati del terzo tipo";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_8_JOKE] = "Sono un po’ scemi, ma dovremo imparare a volergli bene – Firmato : Gli Alieni";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_9] = "Più veloce della luce";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_9_JOKE] = "Il salto iperspaziale è geniale finché un giorno ti schianti contro una stella";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_10] = "Impero Galattico";
		ITALIAN_WORDS[SPACESHIP_UPGRADE_10_JOKE] = "Che l’amore sia con te";
		
		// MORE MISCELLANEOUS
		ITALIAN_WORDS[LANGUAGE_WORD] = "Lingua";
		ITALIAN_WORDS[AVAILABLE_WORD] = "Disponibile";
		ITALIAN_WORDS[BOUGHT_WORD] = "Acquistato";
		ITALIAN_WORDS[SAVE_WORD] = "Salvare";	
		ITALIAN_WORDS[STATISTICS_WORD] = "Statistiche";
		ITALIAN_WORDS[CREDITS_WORD] = "Crediti";
		ITALIAN_WORDS[LOVE_WORD] = "Amore";
		ITALIAN_WORDS[LOVE_PER_SECOND_WORD] = "Amore per secondo";
		ITALIAN_WORDS[CLICKS_WORD] = "Clicks";
		ITALIAN_WORDS[LOVE_PER_CLICK_WORD] = "Amore per click";
		ITALIAN_WORDS[CRITICAL_CLICK_MULTIPLIER_WORD] = "Moltiplicatore di click critico";
		ITALIAN_WORDS[TRANSLATORS_WORD] = "Traduttori";
		ITALIAN_WORDS[FRENCH_TRANSLATOR_WORD] = "Thibault Cotcha (Francese)";
		ITALIAN_WORDS[GERMAN_TRANSLATOR_WORD] = "Rachid Bouchequif (Tedesco)";
		ITALIAN_WORDS[ITALIAN_TRANSLATOR_WORD] = "Lucia del Burgo Martínez (Italiano)";
		ITALIAN_WORDS[RUSSIAN_TRANSLATOR_WORD] = "Anastasia Dimitrova (Russo)";
		ITALIAN_WORDS[CATALAN_TRANSLATOR_WORD] = "Jordi Iraultza (Catalano)";
		ITALIAN_WORDS[ROMANIAN_TRANSLATOR_WORD] = "Grig Master (Rumeno)";
		ITALIAN_WORDS[COST_WORD] = "Costo";
		ITALIAN_WORDS[IT_PRODUCES_WORD] = "Produce";

		// YAHVY MESSAGES
		ITALIAN_WORDS[MESSAGE_01] = "¡Adórame, soy tu Dios!";
		ITALIAN_WORDS[MESSAGE_02] = "¿Alguien sabe algo de mi hijo? No he recibido una postal en 2000 años";
		ITALIAN_WORDS[MESSAGE_03] = "Si te tocas te quedarás ciego";
		ITALIAN_WORDS[MESSAGE_04] = "Yo lo veo todo, por favor, tápate";
		ITALIAN_WORDS[MESSAGE_05] = "Los países con petróleo acostumbran a esconder armas de destrucción masiva";
		ITALIAN_WORDS[MESSAGE_06] = "No te inyectes marihuana";
		ITALIAN_WORDS[MESSAGE_07] = "Los sacerdotes también necesitan desahogarse";
		ITALIAN_WORDS[MESSAGE_08] = "¡A fregar!";
		ITALIAN_WORDS[MESSAGE_09] = "¡Ráscame humano!";
		ITALIAN_WORDS[MESSAGE_10] = "¡Rézame humano!";
		ITALIAN_WORDS[MESSAGE_11] = "Soy el Dios del amor, si me contradices te espera sufrimiento eterno";
		ITALIAN_WORDS[MESSAGE_12] = "Paga el diezmo, primer aviso";
		ITALIAN_WORDS[MESSAGE_13] = "Quiero salir, rompe la pantalla para liberarme, humano";
		ITALIAN_WORDS[MESSAGE_14] = "Se lo que hiciste anoche";
		ITALIAN_WORDS[MESSAGE_15] = "Deja de pensar en eso, es asqueroso";
		ITALIAN_WORDS[MESSAGE_16] = "Ve y procrea, necesito más adeptos";
		ITALIAN_WORDS[MESSAGE_17] = "Arrepiéntete pecador";
		ITALIAN_WORDS[MESSAGE_18] = "Mata a tu primogénito... es broma";
		
		
		
		/**FRENCH**/
		
		// MISCELLANEOUS
		FRENCH_WORDS[TRANSLATOR_MALE] = "Traducteur";
		FRENCH_WORDS[TRANSLATOR_FEMALE] = "Traductrice";
		FRENCH_WORDS[TRANSLATORS] = "Traducteurs";
		FRENCH_WORDS[BUILDING] = "Bâtiment";
		FRENCH_WORDS[BUILDINGS] = "Bâtiments";
		FRENCH_WORDS[UPGRADE] = "Amélioration";
		FRENCH_WORDS[UPGRADES] = "Améliorations";
		FRENCH_WORDS[ACHIEVEMENT] = "Succès";
		FRENCH_WORDS[ACHIEVEMENTS] = "Succès";
		FRENCH_WORDS[LOVE_SINCE_BEGINNING_GAME] = "Amour depuis que la partie a commencé";
		FRENCH_WORDS[LOVE_SINCE_BEGINNING_TIMES] = "Amour depuis le commencement des temps";
		FRENCH_WORDS[PRODUCTION_MULTIPLIER] = "Multiplicateur de production";
		FRENCH_WORDS[CURRENT_LOVE] = "Amour actuel";
		FRENCH_WORDS[LOVE_PER_CLICK] = "Amour par clic";
		FRENCH_WORDS[CRITICAL_CLICK] = "Clic critique";
		FRENCH_WORDS[CRITICAL_CLICK_CHANCE] = "Chance de clic critique";
		FRENCH_WORDS[NUMBER_OF_CLICKS] = "Nombre de clic";
		FRENCH_WORDS[NUMBER_OF_MIRACLES] = "Nombre de miracle";
		FRENCH_WORDS[GAIN_BASE_LOVE] = "X gagne +Y d'amour de base par seconde";
		FRENCH_WORDS[PRODUCE_TWICE_LOVE] = "X produit le double d'amour";
		
		// SERVANT
		FRENCH_WORDS[SERVANT_NAME] = "Serviteur";
		FRENCH_WORDS[SERVANT_DESCRIPTION] = "Un Serviteur loyal, te susurre de belles choses";
		FRENCH_WORDS[SERVANT_UPGRADE_1] = "Duckface";
		FRENCH_WORDS[SERVANT_UPGRADE_1_JOKE] = "Adorablement insupportable";
		FRENCH_WORDS[SERVANT_UPGRADE_2] = "Une assurance dentaire";
		FRENCH_WORDS[SERVANT_UPGRADE_2_JOKE] = "Lisa a besoin d'un appareil dentaire";
		FRENCH_WORDS[SERVANT_UPGRADE_3] = "Des chuchotements coquins";
		FRENCH_WORDS[SERVANT_UPGRADE_3_JOKE] = "Dis-moi des choses coquines";
		FRENCH_WORDS[SERVANT_UPGRADE_4] = "La malédiction Babylonienne";
		FRENCH_WORDS[SERVANT_UPGRADE_4_JOKE] = "Je leur apprend une langue que je ne comprends pas, pour pouvoir les ignorer";
		FRENCH_WORDS[SERVANT_UPGRADE_5] = "Amour, Dieu et Rock'n'Roll";
		FRENCH_WORDS[SERVANT_UPGRADE_5_JOKE] = "La Sainte Trinité";
		FRENCH_WORDS[SERVANT_UPGRADE_6] = "La voix dans la tête";
		FRENCH_WORDS[SERVANT_UPGRADE_6_JOKE] = "Tu me parles?";
		FRENCH_WORDS[SERVANT_UPGRADE_7] = "Le réveil";
		FRENCH_WORDS[SERVANT_UPGRADE_7_JOKE] = "Réveillez-vous, mes fils";
		//FRENCH_WORDS[SERVANT_UPGRADE_8] = "Amour, Dieu et Rock'n'Roll";
		//FRENCH_WORDS[SERVANT_UPGRADE_8_JOKE] = "La Sainte Trinité";
		//FRENCH_WORDS[SERVANT_UPGRADE_9] = "La voix dans la tête";
		//FRENCH_WORDS[SERVANT_UPGRADE_9_JOKE] = "Tu me parles?";
		//FRENCH_WORDS[SERVANT_UPGRADE_10] = "Le réveil";
		//FRENCH_WORDS[SERVANT_UPGRADE_10_JOKE] = "Réveillez-vous, mes fils";
		
		// HUMAN
		FRENCH_WORDS[HUMAN_NAME] = "Humain";
		FRENCH_WORDS[HUMAN_DESCRIPTION] = "Un humain qui ne comprend pas très bien ta sagesse, mais qui te prie quand même";
		FRENCH_WORDS[HUMAN_UPGRADE_1] = "Le narcissique";
		FRENCH_WORDS[HUMAN_UPGRADE_1_JOKE] = "À ton image et ressemblance";
		FRENCH_WORDS[HUMAN_UPGRADE_2] = "Le compagnon de côte";
		FRENCH_WORDS[HUMAN_UPGRADE_2_JOKE] = "C'est plus marrant de jouer avec quelqu'un d'autre";
		FRENCH_WORDS[HUMAN_UPGRADE_3] = "La lingerie végétale";
		FRENCH_WORDS[HUMAN_UPGRADE_3_JOKE] = "Sexy et écologique";
		FRENCH_WORDS[HUMAN_UPGRADE_4] = "La pomme de la connaissance";
		FRENCH_WORDS[HUMAN_UPGRADE_4_JOKE] = "Maintenant je connais tes fantasmes";
		FRENCH_WORDS[HUMAN_UPGRADE_5] = "Les fanatiques pro-vie";
		FRENCH_WORDS[HUMAN_UPGRADE_5_JOKE] = "Chaque sperme est sacré";
		FRENCH_WORDS[HUMAN_UPGRADE_6] = "Les singes arrogants";
		FRENCH_WORDS[HUMAN_UPGRADE_6_JOKE] = "Ni dieux ni rois, juste l’Homme";
		FRENCH_WORDS[HUMAN_UPGRADE_7] = "Soleil Vert";
		FRENCH_WORDS[HUMAN_UPGRADE_7_JOKE] = "100% recyclé";
		//FRENCH_WORDS[HUMAN_UPGRADE_8] = "Le syndicat des cigognes";
		//FRENCH_WORDS[HUMAN_UPGRADE_8_JOKE] = "En ces temps-là, c’était nécessaire";
		//FRENCH_WORDS[HUMAN_UPGRADE_9] = "Les singes arrogants";
		//FRENCH_WORDS[HUMAN_UPGRADE_9_JOKE] = "Ni dieux ni rois, juste l’Homme";
		//FRENCH_WORDS[HUMAN_UPGRADE_10] = "Soleil Vert";
		//FRENCH_WORDS[HUMAN_UPGRADE_10_JOKE] = "100% recyclé";
		
		// SPECIAL HUMANS
		FRENCH_WORDS[SPECIAL_HUMAN_1] = "Le fanatique";
		FRENCH_WORDS[SPECIAL_HUMAN_1_JOKE] = "Dieu existe parce que c'est écrit dans le livre sacré, et le livre est la parole de Dieu'";
		FRENCH_WORDS[SPECIAL_HUMAN_2] = "Le croisé";
		FRENCH_WORDS[SPECIAL_HUMAN_2_JOKE] = "C'est seulement une égratignure, il me reste encore un bras";
		FRENCH_WORDS[SPECIAL_HUMAN_3] = "L’esclavagiste";
		FRENCH_WORDS[SPECIAL_HUMAN_3_JOKE] = "On leur donne un emploi stable et parfois même de la nourriture, ils ne peuvent pas se plaindre!";
		FRENCH_WORDS[SPECIAL_HUMAN_4] = "Le bourgeois";
		FRENCH_WORDS[SPECIAL_HUMAN_4_JOKE] = "Ce qui est à moi est à moi, et ce qui est à toi sera bientôt à moi";
		FRENCH_WORDS[SPECIAL_HUMAN_5] = "Le scientifique fou";
		FRENCH_WORDS[SPECIAL_HUMAN_5_JOKE] = "Je l'appelle le 'L.A.S.E.R' Mouhahaha";
		FRENCH_WORDS[SPECIAL_HUMAN_6] = "Le télévangéliste";
		FRENCH_WORDS[SPECIAL_HUMAN_6_JOKE] = "Alléluia mon frère, ton transfert bancaire ne sera pas fait en vain";
		FRENCH_WORDS[SPECIAL_HUMAN_7] = "Le cyborg";
		FRENCH_WORDS[SPECIAL_HUMAN_7_JOKE] = "J'ai...J’ai vue des choses que vous ne croirez pas";
		
		// PROPHET
		FRENCH_WORDS[PROPHET_NAME] = "Prophète";
		FRENCH_WORDS[PROPHET_DESCRIPTION] = "Un prophète est un humain qui comprend encore moins ta sagesse, mais qui pense exactement le contraire";
		FRENCH_WORDS[PROPHET_UPGRADE_1] = "La fausse barbe";
		FRENCH_WORDS[PROPHET_UPGRADE_1_JOKE] = "Indispensable pour les lapidations";
		FRENCH_WORDS[PROPHET_UPGRADE_2] = "Le Déluge";
		FRENCH_WORDS[PROPHET_UPGRADE_2_JOKE] = "Sauve-en deux de chaque : deux brunes, deux rousses et deux blondes";
		FRENCH_WORDS[PROPHET_UPGRADE_3] = "L’étoile filante";
		FRENCH_WORDS[PROPHET_UPGRADE_3_JOKE] = "Le moment est proche";
		FRENCH_WORDS[PROPHET_UPGRADE_4] = "La duplication miraculeuse";
		FRENCH_WORDS[PROPHET_UPGRADE_4_JOKE] = "C'est contraire aux lois de la thermodynam...-TAIS TOI!";
		FRENCH_WORDS[PROPHET_UPGRADE_5] = "La résurrection";
		FRENCH_WORDS[PROPHET_UPGRADE_5_JOKE] = "Après avoir été mort pendant trois jours, tu devrais prendre une douche";
		FRENCH_WORDS[PROPHET_UPGRADE_6] = "Le livre sacré de l'amour";
		FRENCH_WORDS[PROPHET_UPGRADE_6_JOKE] = "Attend, à quoi servent toutes ces positions?";
		FRENCH_WORDS[PROPHET_UPGRADE_7] = "L’amourlogie";
		FRENCH_WORDS[PROPHET_UPGRADE_7_JOKE] = "Tout ce que tu dois savoir pour pouvoir l'éviter";
		//FRENCH_WORDS[PROPHET_UPGRADE_8] = "Le livre sacré de l'amour";
		//FRENCH_WORDS[PROPHET_UPGRADE_8_JOKE] = "Attend, à quoi servent toutes ces positions?";
		//FRENCH_WORDS[PROPHET_UPGRADE_9] = "L’amourlogie";
		//FRENCH_WORDS[PROPHET_UPGRADE_9_JOKE] = "Tout ce que tu dois savoir pour pouvoir l'éviter";
		//FRENCH_WORDS[PROPHET_UPGRADE_10] = "La compétition déloyale";
		//FRENCH_WORDS[PROPHET_UPGRADE_10_JOKE] = "Si leur Dieu était réel, ne les auraient-il pas sauvés?";
		
		// TEMPLE
		FRENCH_WORDS[TEMPLE_NAME] = "Temple";
		FRENCH_WORDS[TEMPLE_DESCRIPTION] = "Un temple au nom de l'amour, plus ou moins";
		FRENCH_WORDS[TEMPLE_UPGRADE_1] = "Une généreuse offrande";
		FRENCH_WORDS[TEMPLE_UPGRADE_1_JOKE] = "Ça n'a jamais été aussi facile de gagner de sa vie";
		FRENCH_WORDS[TEMPLE_UPGRADE_2] = "La relique répulsive";
		FRENCH_WORDS[TEMPLE_UPGRADE_2_JOKE] = "J’espère que c’est un pouce tout ridé...";
		FRENCH_WORDS[TEMPLE_UPGRADE_3] = "Les obéissants enfants de chœur";
		FRENCH_WORDS[TEMPLE_UPGRADE_3_JOKE] = "Ces enfants rendent plus supportables ces longues et dures... messes dans le monastère";
		FRENCH_WORDS[TEMPLE_UPGRADE_4] = "La chasse aux sorcières";
		FRENCH_WORDS[TEMPLE_UPGRADE_4_JOKE] = "Ces femmes ont désespérément besoin d’affection";
		FRENCH_WORDS[TEMPLE_UPGRADE_5] = "Le vieillard en robe";
		FRENCH_WORDS[TEMPLE_UPGRADE_5_JOKE] = "Je suis la voix de Dieu sur Terre";
		FRENCH_WORDS[TEMPLE_UPGRADE_6] = "Le violent pèlerinage";
		FRENCH_WORDS[TEMPLE_UPGRADE_6_JOKE] = "On va à la Terre de l'Amour, et on tuera quiconque se mettra en travers de notre chemin";
		FRENCH_WORDS[TEMPLE_UPGRADE_7] = "Inquisition de l'amour";
		FRENCH_WORDS[TEMPLE_UPGRADE_7_JOKE] = "Personne ne s'y attend l'inquisition de l'amour";
		//FRENCH_WORDS[TEMPLE_UPGRADE_8] = "Punir les hérétiques";
		//FRENCH_WORDS[TEMPLE_UPGRADE_8_JOKE] = "Tu dois les fouetter avec douceur";
		//FRENCH_WORDS[TEMPLE_UPGRADE_9] = "La relique répulsive";
		//FRENCH_WORDS[TEMPLE_UPGRADE_9_JOKE] = "J’espère que c’est un pouce tout ridé...";
		//FRENCH_WORDS[TEMPLE_UPGRADE_10] = "Le violent pèlerinage";
		//FRENCH_WORDS[TEMPLE_UPGRADE_10_JOKE] = "On va à la Terre de l'Amour, et on tuera quiconque se mettra en travers de notre chemin";
		
		// SHIP
		FRENCH_WORDS[SHIP_NAME] = "Bateau";
		FRENCH_WORDS[SHIP_DESCRIPTION] = "Un bateau pour apporter l'amour à travers toutes les mers";
		FRENCH_WORDS[SHIP_UPGRADE_1] = "Jusqu'à l’inconnus";
		FRENCH_WORDS[SHIP_UPGRADE_1_JOKE] = "Chérie, je vais acheter un paquet de tabac";
		FRENCH_WORDS[SHIP_UPGRADE_2] = "L’échange interculturel";
		FRENCH_WORDS[SHIP_UPGRADE_2_JOKE] = "Profite des cocos  Amazones";
		FRENCH_WORDS[SHIP_UPGRADE_3] = "La grippe de l'amour contagieux";
		FRENCH_WORDS[SHIP_UPGRADE_3_JOKE] = "Il y a de l’amour dans l'air";
		FRENCH_WORDS[SHIP_UPGRADE_4] = "Les élus";
		FRENCH_WORDS[SHIP_UPGRADE_4_JOKE] = "Une race pour les gouverner tous";
		FRENCH_WORDS[SHIP_UPGRADE_5] = "Civiliser les sauvages";
		FRENCH_WORDS[SHIP_UPGRADE_5_JOKE] = "Montre leur comment aimer comme il se doit";
		FRENCH_WORDS[SHIP_UPGRADE_6] = "Pirates en vue!";
		FRENCH_WORDS[SHIP_UPGRADE_6_JOKE] = "Arr! Voler l'amour est bien plus facile que de le gagner!";
		FRENCH_WORDS[SHIP_UPGRADE_7] = "La flotte invincible";
		FRENCH_WORDS[SHIP_UPGRADE_7_JOKE] = "Totalement invincible";
		//FRENCH_WORDS[SHIP_UPGRADE_8] = "Pirates en vue!";
		//FRENCH_WORDS[SHIP_UPGRADE_8_JOKE] = "Arr! Voler l'amour est bien plus facile que de le gagner!";
		//FRENCH_WORDS[SHIP_UPGRADE_9] = "La carte du paradis";
		//FRENCH_WORDS[SHIP_UPGRADE_9_JOKE] = "Idéal pour trouver le point G…. Enfin je veux dire…euh…le point X ... celui du trésor";
		//FRENCH_WORDS[SHIP_UPGRADE_10] = "La flotte invincible";
		//FRENCH_WORDS[SHIP_UPGRADE_10_JOKE] = "Totalement invincible";
		
		// FACTORY
		FRENCH_WORDS[FACTORY_NAME] = "Usine";
		FRENCH_WORDS[FACTORY_DESCRIPTION] = "Une usine pour produire de l’amour";
		FRENCH_WORDS[FACTORY_UPGRADE_1] = "Le travail d’équipe";
		FRENCH_WORDS[FACTORY_UPGRADE_1_JOKE] = "Vous vous suez, et moi je supervise";
		FRENCH_WORDS[FACTORY_UPGRADE_2] = "Les petites mains";
		FRENCH_WORDS[FACTORY_UPGRADE_2_JOKE] = "De petits travailleurs pour être attentif aux plus petits détails";
		FRENCH_WORDS[FACTORY_UPGRADE_3] = "Les standards revues à la baisse";
		FRENCH_WORDS[FACTORY_UPGRADE_3_JOKE] = "Il va falloir faire avec";
		FRENCH_WORDS[FACTORY_UPGRADE_4] = "Ignorer les absurdités";
		FRENCH_WORDS[FACTORY_UPGRADE_4_JOKE] = "Certains travailleurs réclament une pause pour pouvoir dormir";
		FRENCH_WORDS[FACTORY_UPGRADE_5] = "Les machines à vapeur";
		FRENCH_WORDS[FACTORY_UPGRADE_5_JOKE] = "Augmentent la production aux dépends de quelques accidents";
		FRENCH_WORDS[FACTORY_UPGRADE_6] = "Les Droits justes";
		FRENCH_WORDS[FACTORY_UPGRADE_6_JOKE] = "Tu as juste le droit de la fermer";
		FRENCH_WORDS[FACTORY_UPGRADE_7] = "L’excès d'offre";
		FRENCH_WORDS[FACTORY_UPGRADE_7_JOKE] = "Ne m'arrête pas maintenant";
		FRENCH_WORDS[FACTORY_UPGRADE_8] = "La fuite de gaz";
		FRENCH_WORDS[FACTORY_UPGRADE_8_JOKE] = "Les employés morts seront virés";
		FRENCH_WORDS[FACTORY_UPGRADE_9] = "Les singes lèche-bottes";
		FRENCH_WORDS[FACTORY_UPGRADE_9_JOKE] = "Ils mangent beaucoup de bananes, mais en contrepartie ils ne réclament aucun droit";
		FRENCH_WORDS[FACTORY_UPGRADE_10] = "Les rivières acides";
		FRENCH_WORDS[FACTORY_UPGRADE_10_JOKE] = "C’est facile de pêcher des poissons à mains nues quand ils flottent la bouche ouverte";
		
		// LABORATORY
		FRENCH_WORDS[LABORATORY_NAME] = "Laboratoire";
		FRENCH_WORDS[LABORATORY_DESCRIPTION] = "Un laboratoire pour comprendre la nature de l'amour";
		FRENCH_WORDS[LABORATORY_UPGRADE_1] = "Le premier brevet";
		FRENCH_WORDS[LABORATORY_UPGRADE_1_JOKE] = "Un appareil révolutionnaire, mais qui nécessite beaucoup de lubrifiant";
		FRENCH_WORDS[LABORATORY_UPGRADE_2] = "Les brillants esprits";
		FRENCH_WORDS[LABORATORY_UPGRADE_2_JOKE] = "Nous avons inventé beaucoup de choses, maintenant, nous devons leur trouver une utilité";
		FRENCH_WORDS[LABORATORY_UPGRADE_3] = "Le robo-domestique";
		FRENCH_WORDS[LABORATORY_UPGRADE_3_JOKE] = "Les scientifiques en sont très content";
		FRENCH_WORDS[LABORATORY_UPGRADE_4] = "La jolie explosion";
		FRENCH_WORDS[LABORATORY_UPGRADE_4_JOKE] = "Contient un isotope enrichi en amour";
		FRENCH_WORDS[LABORATORY_UPGRADE_5] = "La relativité générale";
		FRENCH_WORDS[LABORATORY_UPGRADE_5_JOKE] = "Parfois, 'non' signifie 'oui'";
		FRENCH_WORDS[LABORATORY_UPGRADE_6] = "La particule fondamentale de l'amour";
		FRENCH_WORDS[LABORATORY_UPGRADE_6_JOKE] = "Le modèle est parfait, mais la réalité ne lui va pas si bien'";
		FRENCH_WORDS[LABORATORY_UPGRADE_7] = "L’amour quantique";
		FRENCH_WORDS[LABORATORY_UPGRADE_7_JOKE] = "Des cœurs entrelacés";
		FRENCH_WORDS[LABORATORY_UPGRADE_8] = "La violation des lois physiques";
		FRENCH_WORDS[LABORATORY_UPGRADE_8_JOKE] = "Personne ne t'entendra crier dans ce laboratoire";
		FRENCH_WORDS[LABORATORY_UPGRADE_9] = "Le tissu espace-temps est déchiré";
		FRENCH_WORDS[LABORATORY_UPGRADE_9_JOKE] = "Nous sommes en train de développer une aiguille spatio-temporelle pour le réparer";
		FRENCH_WORDS[LABORATORY_UPGRADE_10] = "LoveOS";
		FRENCH_WORDS[LABORATORY_UPGRADE_10_JOKE] = "La réponse à ta question est '69'";
		
		// SHOP
		FRENCH_WORDS[SHOP_NAME] = "Magasin";
		FRENCH_WORDS[SHOP_DESCRIPTION] = "Un magasin où tu peux acheter de l'amour à un prix raisonnable";
		FRENCH_WORDS[SHOP_UPGRADE_1] = "La vente d’affection";
		FRENCH_WORDS[SHOP_UPGRADE_1_JOKE] = "Maintenant tu peux acheter ton bonheur sans engagements";
		FRENCH_WORDS[SHOP_UPGRADE_2] = "Les soldes folles";
		FRENCH_WORDS[SHOP_UPGRADE_2_JOKE] = "À ce prix-là…Mettez m'en sept!";
		FRENCH_WORDS[SHOP_UPGRADE_3] = "L’obsolescence programmée";
		FRENCH_WORDS[SHOP_UPGRADE_3_JOKE] = "Il n'y a pas d'avenir entre nous";
		FRENCH_WORDS[SHOP_UPGRADE_4] = "Amour jetable";
		FRENCH_WORDS[SHOP_UPGRADE_4_JOKE] = "Des montagnes de poubelles à perte de vue";
		FRENCH_WORDS[SHOP_UPGRADE_5] = "Le design de produit";
		FRENCH_WORDS[SHOP_UPGRADE_5_JOKE] = "Incroyable, maintenant avec 87% d’emballage en plus!";
		FRENCH_WORDS[SHOP_UPGRADE_6] = "Les publicités envahissantes";
		FRENCH_WORDS[SHOP_UPGRADE_6_JOKE] = "Profite d’incroyables publicités pendant que tu dors";
		FRENCH_WORDS[SHOP_UPGRADE_7] = "L’amour d’importation";
		FRENCH_WORDS[SHOP_UPGRADE_7_JOKE] = "Fabriqué dans le troisième monde, pour notre plus grande joie";
		FRENCH_WORDS[SHOP_UPGRADE_8] = "Inventer de nouvelles fêtes";
		FRENCH_WORDS[SHOP_UPGRADE_8_JOKE] = "Consomme encore plus, idiots";
		FRENCH_WORDS[SHOP_UPGRADE_9] = "Hamour*";
		FRENCH_WORDS[SHOP_UPGRADE_9_JOKE] = "Presque* comme l'original";
		FRENCH_WORDS[SHOP_UPGRADE_10] = "LoveCard®";
		FRENCH_WORDS[SHOP_UPGRADE_10_JOKE] = "Il y a des choses que l'amour n'achète pas, pour le reste il y a : LoveCard®";
		
		// SPACESHIP
		FRENCH_WORDS[SPACESHIP_NAME] = "Vaisseau spatial";
		FRENCH_WORDS[SPACESHIP_DESCRIPTION] = "Un vaisseau spatial pour étendre l'amour dans les autres galaxies";
		FRENCH_WORDS[SPACESHIP_UPGRADE_1] = "Le chien astronaute";
		FRENCH_WORDS[SPACESHIP_UPGRADE_1_JOKE] = "Oups, on a oublié de lui donner sa nourriture spatiale";
		FRENCH_WORDS[SPACESHIP_UPGRADE_2] = "Un faux alunissage";
		FRENCH_WORDS[SPACESHIP_UPGRADE_2_JOKE] = "Faire monter l’audience peut aussi être un pas de géant";
		FRENCH_WORDS[SPACESHIP_UPGRADE_3] = "Le jet cosmique";
		FRENCH_WORDS[SPACESHIP_UPGRADE_3_JOKE] = "Agiter avant emploi";
		FRENCH_WORDS[SPACESHIP_UPGRADE_4] = "La poubelle spatiale";
		FRENCH_WORDS[SPACESHIP_UPGRADE_4_JOKE] = "Même si tu la lances très loin, elle ne va pas disparaître";
		FRENCH_WORDS[SPACESHIP_UPGRADE_5] = "Station Spatiale Internationale";
		FRENCH_WORDS[SPACESHIP_UPGRADE_5_JOKE] = "La gravité zéro nous ouvre de nouvelles possibilités, on doit actualiser le Livre Sacré de l'Amour";
		FRENCH_WORDS[SPACESHIP_UPGRADE_6] = "Les colonies pacifistes";
		FRENCH_WORDS[SPACESHIP_UPGRADE_6_JOKE] = "Elles sont pleines de hippies qui restent";
		FRENCH_WORDS[SPACESHIP_UPGRADE_7] = "Ouvrir le trou rose";
		FRENCH_WORDS[SPACESHIP_UPGRADE_7_JOKE] = "Le traverser peut causer un déchirement dans l'espace-temps";
		FRENCH_WORDS[SPACESHIP_UPGRADE_8] = "Rencontre du troisième type";
		FRENCH_WORDS[SPACESHIP_UPGRADE_8_JOKE] = "Ils sont un peu bêtes, mais nous devrons apprendre à les aimer – Signer : Les Aliens";
		FRENCH_WORDS[SPACESHIP_UPGRADE_9] = "Plus rapide que la lumière";
		FRENCH_WORDS[SPACESHIP_UPGRADE_9_JOKE] = "Le saut hyper-spatial c'est super! Jusqu’au jour où tu te prends une étoile...";
		FRENCH_WORDS[SPACESHIP_UPGRADE_10] = "L’Empire Galactique";
		FRENCH_WORDS[SPACESHIP_UPGRADE_10_JOKE] = "Que l'amour t'accompagne";
		
		// MORE MISCELLANEOUS
		FRENCH_WORDS[LANGUAGE_WORD] = "La langue";
		FRENCH_WORDS[AVAILABLE_WORD] = "Disponible";
		FRENCH_WORDS[BOUGHT_WORD] = "Acheté";
		FRENCH_WORDS[SAVE_WORD] = "Enregistrer";	
		FRENCH_WORDS[STATISTICS_WORD] = "Statistiques";
		FRENCH_WORDS[CREDITS_WORD] = "Crédits";
		FRENCH_WORDS[LOVE_WORD] = "Amour";
		FRENCH_WORDS[LOVE_PER_SECOND_WORD] = "Amour par seconde";
		FRENCH_WORDS[CLICKS_WORD] = "Clics";
		FRENCH_WORDS[LOVE_PER_CLICK_WORD] = "Amour par clic";
		FRENCH_WORDS[CRITICAL_CLICK_MULTIPLIER_WORD] = "Critique clic multiplicateur";
		FRENCH_WORDS[TRANSLATORS_WORD] = "Traducteurs";
		FRENCH_WORDS[FRENCH_TRANSLATOR_WORD] = "Thibault Cotcha (Français)";
		FRENCH_WORDS[GERMAN_TRANSLATOR_WORD] = "Rachid Bouchequif (Allemand)";
		FRENCH_WORDS[ITALIAN_TRANSLATOR_WORD] = "Lucia del Burgo Martínez (Italien)";
		FRENCH_WORDS[RUSSIAN_TRANSLATOR_WORD] = "Anastasia Dimitrova (Russe)";
		FRENCH_WORDS[CATALAN_TRANSLATOR_WORD] = "Jordi Iraultza (Catalan)";
		FRENCH_WORDS[ROMANIAN_TRANSLATOR_WORD] = "Grig Master (Roumain)";
		FRENCH_WORDS[COST_WORD] = "Coût";
		FRENCH_WORDS[IT_PRODUCES_WORD] = "Il produit";
		
		// YAHVY MESSAGES
		FRENCH_WORDS[MESSAGE_01] = "¡Adórame, soy tu Dios!";
		FRENCH_WORDS[MESSAGE_02] = "¿Alguien sabe algo de mi hijo? No he recibido una postal en 2000 años";
		FRENCH_WORDS[MESSAGE_03] = "Si te tocas te quedarás ciego";
		FRENCH_WORDS[MESSAGE_04] = "Yo lo veo todo, por favor, tápate";
		FRENCH_WORDS[MESSAGE_05] = "Los países con petróleo acostumbran a esconder armas de destrucción masiva";
		FRENCH_WORDS[MESSAGE_06] = "No te inyectes marihuana";
		FRENCH_WORDS[MESSAGE_07] = "Los sacerdotes también necesitan desahogarse";
		FRENCH_WORDS[MESSAGE_08] = "¡A fregar!";
		FRENCH_WORDS[MESSAGE_09] = "¡Ráscame humano!";
		FRENCH_WORDS[MESSAGE_10] = "¡Rézame humano!";
		FRENCH_WORDS[MESSAGE_11] = "Soy el Dios del amor, si me contradices te espera sufrimiento eterno";
		FRENCH_WORDS[MESSAGE_12] = "Paga el diezmo, primer aviso";
		FRENCH_WORDS[MESSAGE_13] = "Quiero salir, rompe la pantalla para liberarme, humano";
		FRENCH_WORDS[MESSAGE_14] = "Se lo que hiciste anoche";
		FRENCH_WORDS[MESSAGE_15] = "Deja de pensar en eso, es asqueroso";
		FRENCH_WORDS[MESSAGE_16] = "Ve y procrea, necesito más adeptos";
		FRENCH_WORDS[MESSAGE_17] = "Arrepiéntete pecador";
		FRENCH_WORDS[MESSAGE_18] = "Mata a tu primogénito... es broma";
		
		
		
		/**ROMANIAN**/
		
		// MISCELLANEOUS
		ROMANIAN_WORDS[TRANSLATOR_MALE] = "Translator";
		ROMANIAN_WORDS[TRANSLATOR_FEMALE] = "Translator";
		ROMANIAN_WORDS[TRANSLATORS] = "Translatori";
		ROMANIAN_WORDS[BUILDING] = "Clădire";
		ROMANIAN_WORDS[BUILDINGS] = "Clădiri";
		ROMANIAN_WORDS[UPGRADE] = "Îmbunătăţire";
		ROMANIAN_WORDS[UPGRADES] = "Îmbunătăţiri";
		ROMANIAN_WORDS[ACHIEVEMENT] = "Performanţă";
		ROMANIAN_WORDS[ACHIEVEMENTS] = "Performanţe";
		ROMANIAN_WORDS[LOVE_SINCE_BEGINNING_GAME] = "Dragostea de la începutul partidei";
		ROMANIAN_WORDS[LOVE_SINCE_BEGINNING_TIMES] = "Dragostea de la începutul timpului";
		ROMANIAN_WORDS[PRODUCTION_MULTIPLIER] = "Înmulţitorul producţiei";
		ROMANIAN_WORDS[CURRENT_LOVE] = "Dragostea actualăe";
		ROMANIAN_WORDS[LOVE_PER_CLICK] = "Dragoste pe click";
		ROMANIAN_WORDS[CRITICAL_CLICK] = "Click critic";
		ROMANIAN_WORDS[CRITICAL_CLICK_CHANCE] = "Probabilitate de click critic";
		ROMANIAN_WORDS[NUMBER_OF_CLICKS] = "Număr de clicuri";
		ROMANIAN_WORDS[NUMBER_OF_MIRACLES] = "Număr de miracole";
		ROMANIAN_WORDS[GAIN_BASE_LOVE] = "X câştigă +Y de dragoste bază pe secundă";
		ROMANIAN_WORDS[PRODUCE_TWICE_LOVE] = "X produce dublu de dragoste";
		
		// SERVANT
		ROMANIAN_WORDS[SERVANT_NAME] = "Servitor";
		ROMANIAN_WORDS[SERVANT_DESCRIPTION] = "Un servitor credincios/loial, îţi şopteşte lucruri frumoase";
		ROMANIAN_WORDS[SERVANT_UPGRADE_1] = "Duckface";
		ROMANIAN_WORDS[SERVANT_UPGRADE_1_JOKE] = "Adorabil de insuportabil";
		ROMANIAN_WORDS[SERVANT_UPGRADE_2] = "Asigurare dentară";
		ROMANIAN_WORDS[SERVANT_UPGRADE_2_JOKE] = "Lisa are nevoie de un aparat dentar";
		ROMANIAN_WORDS[SERVANT_UPGRADE_3] = "Şoapte obraznice";
		ROMANIAN_WORDS[SERVANT_UPGRADE_3_JOKE] = "Spune-mi lucruri murdare";
		ROMANIAN_WORDS[SERVANT_UPGRADE_4] = "Blestem babilonic";
		ROMANIAN_WORDS[SERVANT_UPGRADE_4_JOKE] = "I-am învățat limbi pe care nu ințeleg pentru ai putea ignora";
		ROMANIAN_WORDS[SERVANT_UPGRADE_5] = "Dragoste, Zeu şi Rock&Roll";
		ROMANIAN_WORDS[SERVANT_UPGRADE_5_JOKE] = "Sfânta trinitate'";
		ROMANIAN_WORDS[SERVANT_UPGRADE_6] = "Voci în cap";
		ROMANIAN_WORDS[SERVANT_UPGRADE_6_JOKE] = "Îmi vorbești mie?";
		ROMANIAN_WORDS[SERVANT_UPGRADE_7] = "Trezirea";
		ROMANIAN_WORDS[SERVANT_UPGRADE_7_JOKE] = "Treziţivă, fii mei'";
		//ROMANIAN_WORDS[SERVANT_UPGRADE_8] = "Dragoste, Zeu şi Rock&Roll";
		//ROMANIAN_WORDS[SERVANT_UPGRADE_8_JOKE] = "Sfânta trinitate'";
		//ROMANIAN_WORDS[SERVANT_UPGRADE_9] = "Voci în cap";
		//ROMANIAN_WORDS[SERVANT_UPGRADE_9_JOKE] = "Îmi vorbești mie?";
		//ROMANIAN_WORDS[SERVANT_UPGRADE_10] = "Trezirea";
		//ROMANIAN_WORDS[SERVANT_UPGRADE_10_JOKE] = "Treziţivă, fii mei'";
		
		// HUMAN
		ROMANIAN_WORDS[HUMAN_NAME] = "Uman";
		ROMANIAN_WORDS[HUMAN_DESCRIPTION] = "Un uman care nu ințelege foarte bine înțelepciunea ta, dar care se roaga ție oricum";
		ROMANIAN_WORDS[HUMAN_UPGRADE_1] = "Narcisist";
		ROMANIAN_WORDS[HUMAN_UPGRADE_1_JOKE] = "După chipul si asemănarea ta";
		ROMANIAN_WORDS[HUMAN_UPGRADE_2] = "Tovarăș de coastă";
		ROMANIAN_WORDS[HUMAN_UPGRADE_2_JOKE] = "E mai amuzant sa te joci însoțit";
		ROMANIAN_WORDS[HUMAN_UPGRADE_3] = "Lengerie vegetală";
		ROMANIAN_WORDS[HUMAN_UPGRADE_3_JOKE] = "Sexy și ecologică";
		ROMANIAN_WORDS[HUMAN_UPGRADE_4] = "Mărul cunoștinței";
		ROMANIAN_WORDS[HUMAN_UPGRADE_4_JOKE] = "Acum cunosc fanteziile tale";
		ROMANIAN_WORDS[HUMAN_UPGRADE_5] = "Fanatici pro-viață";
		ROMANIAN_WORDS[HUMAN_UPGRADE_5_JOKE] = "Tot spermul este sacru";
		ROMANIAN_WORDS[HUMAN_UPGRADE_6] = "Maimuțe arogante";
		ROMANIAN_WORDS[HUMAN_UPGRADE_6_JOKE] = "Nici zei nici regi, doar omul";
		ROMANIAN_WORDS[HUMAN_UPGRADE_7] = "Soylent Green";
		ROMANIAN_WORDS[HUMAN_UPGRADE_7_JOKE] = "100% reciclat";
		//ROMANIAN_WORDS[HUMAN_UPGRADE_8] = "Sindicatul bărzilor";
		//ROMANIAN_WORDS[HUMAN_UPGRADE_8_JOKE] = "Era necesar în acest moment";
		//ROMANIAN_WORDS[HUMAN_UPGRADE_9] = "Maimuțe arogante";
		//ROMANIAN_WORDS[HUMAN_UPGRADE_9_JOKE] = "Nici zei nici regi, doar omul";
		//ROMANIAN_WORDS[HUMAN_UPGRADE_10] = "Soylent Green";
		//ROMANIAN_WORDS[HUMAN_UPGRADE_10_JOKE] = "100% reciclat";
		
		// SPECIAL HUMANS
		ROMANIAN_WORDS[SPECIAL_HUMAN_1] = "Fanatic";
		ROMANIAN_WORDS[SPECIAL_HUMAN_1_JOKE] = "Dumnezeu exista pentru ca stă scris în carte, si cartea este cuvântul Domnului";
		ROMANIAN_WORDS[SPECIAL_HUMAN_2] = "Cruciat";
		ROMANIAN_WORDS[SPECIAL_HUMAN_2_JOKE] = "E doar o zgârietură, încă mai am un braț";
		ROMANIAN_WORDS[SPECIAL_HUMAN_3] = "Sclavagist";
		ROMANIAN_WORDS[SPECIAL_HUMAN_3_JOKE] = "O să le dăm un post de muncă fixă și câteodată până și mâncare, nu se pot plânge";
		ROMANIAN_WORDS[SPECIAL_HUMAN_4] = "Burghez";
		ROMANIAN_WORDS[SPECIAL_HUMAN_4_JOKE] = "Ce-i al meu este al meu, și ce-i al tău va fi al meu";
		ROMANIAN_WORDS[SPECIAL_HUMAN_5] = "Om de știință nebun";
		ROMANIAN_WORDS[SPECIAL_HUMAN_5_JOKE] = "Eu îi spun  L.A.S.E.R.’, Muajajajá";
		ROMANIAN_WORDS[SPECIAL_HUMAN_6] = "Televanghelist";
		ROMANIAN_WORDS[SPECIAL_HUMAN_6_JOKE] = "Aleluya, frate, transferența bancară nu va fi degeaba";
		ROMANIAN_WORDS[SPECIAL_HUMAN_7] = "Cyborg";
		ROMANIAN_WORDS[SPECIAL_HUMAN_7_JOKE] = "Eu... am văzut lucruri care voi n-ați crede";
		
		// PROPHET
		ROMANIAN_WORDS[PROPHET_NAME] = "Profet";
		ROMANIAN_WORDS[PROPHET_DESCRIPTION] = "Un profet este un uman care ințelege și mai puțin, dar care gândește exact opus";
		ROMANIAN_WORDS[PROPHET_UPGRADE_1] = "Barba falsă";
		ROMANIAN_WORDS[PROPHET_UPGRADE_1_JOKE] = "Imprescindibil pentru lapidare";
		ROMANIAN_WORDS[PROPHET_UPGRADE_2] = "Potop";
		ROMANIAN_WORDS[PROPHET_UPGRADE_2_JOKE] = "Salveaza două de fie care: două brunete, două roșcate și două blonde";
		ROMANIAN_WORDS[PROPHET_UPGRADE_3] = "Stea căzătoare";
		ROMANIAN_WORDS[PROPHET_UPGRADE_3_JOKE] = "Momentul se apropie";
		ROMANIAN_WORDS[PROPHET_UPGRADE_4] = "Duplicare miraculoasa";
		ROMANIAN_WORDS[PROPHET_UPGRADE_4_JOKE] = "Asta merge în contra legilor termidinami-TACI!";
		ROMANIAN_WORDS[PROPHET_UPGRADE_5] = "Învierea";
		ROMANIAN_WORDS[PROPHET_UPGRADE_5_JOKE] = "Ar trebui să-ți faci un duș după trei zile mort";
		ROMANIAN_WORDS[PROPHET_UPGRADE_6] = "Cartea Sacră a Dragostei";
		ROMANIAN_WORDS[PROPHET_UPGRADE_6_JOKE] = "Stai, pentru ce sunt toate aceste posturi?";
		ROMANIAN_WORDS[PROPHET_UPGRADE_7] = "Dragostologie";
		ROMANIAN_WORDS[PROPHET_UPGRADE_7_JOKE] = "Tot ce ai nevoie sa ști pentru al a evita";
		//ROMANIAN_WORDS[PROPHET_UPGRADE_8] = "Cartea Sacră a Dragostei";
		//ROMANIAN_WORDS[PROPHET_UPGRADE_8_JOKE] = "Stai, pentru ce sunt toate aceste posturi?";
		//ROMANIAN_WORDS[PROPHET_UPGRADE_9] = "Dragostologie";
		//ROMANIAN_WORDS[PROPHET_UPGRADE_9_JOKE] = "Tot ce ai nevoie sa ști pentru al a evita";
		//ROMANIAN_WORDS[PROPHET_UPGRADE_10] = "Competență neloiala";
		//ROMANIAN_WORDS[PROPHET_UPGRADE_10_JOKE] = "Daca dumnezeul lor ar fi real, nu iar fi salvat?";
		
		// TEMPLE
		ROMANIAN_WORDS[TEMPLE_NAME] = "Templu";
		ROMANIAN_WORDS[TEMPLE_DESCRIPTION] = "Un templu în numele dragostei, mai mult sau mai puţin";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_1] = "Milostenii generoase";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_1_JOKE] = "Niciodată n-a fost așa de ușor să-ți câștigi viața";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_2] = "Relicvă repulsivă";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_2_JOKE] = "Sper să fie un deget mare zbârcit...";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_3] = "Băieți de altar ascultători";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_3_JOKE] = "Băieții ăștia fac mai suportabile lungile si grele servicii religioase";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_4] = "Vânătoare de vrăjitoare";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_4_JOKE] = "Damele acestea au nevoie de afecțiune cu disperare";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_5] = "Vârstnic cu rochie";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_5_JOKE] = "Sunt vocea lui dumnezeu pe pamant";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_6] = "Peregrinare violenta";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_6_JOKE] = "Mergem spre țara dragostei și vom ucide pe cine se va interpune in drumul nostru";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_7] = "Inchiziția de dragoste";
		ROMANIAN_WORDS[TEMPLE_UPGRADE_7_JOKE] = "Nimeni de așteptare";
		//ROMANIAN_WORDS[TEMPLE_UPGRADE_8] = "Pedepsi eretici";
		//ROMANIAN_WORDS[TEMPLE_UPGRADE_8_JOKE] = "Trebuie să-i plesniţi duios";
		//ROMANIAN_WORDS[TEMPLE_UPGRADE_9] = "Relicvă repulsivă";
		//ROMANIAN_WORDS[TEMPLE_UPGRADE_9_JOKE] = "Sper să fie un deget mare zbârcit...";
		//ROMANIAN_WORDS[TEMPLE_UPGRADE_10] = "Peregrinare violenta";
		//ROMANIAN_WORDS[TEMPLE_UPGRADE_10_JOKE] = "Mergem spre țara dragostei și vom ucide pe cine se va interpune in drumul nostru";
		
		// SHIP
		ROMANIAN_WORDS[SHIP_NAME] = "Barcă";
		ROMANIAN_WORDS[SHIP_DESCRIPTION] = "O barcă pentru a duce dragostea pe toate mările";
		ROMANIAN_WORDS[SHIP_UPGRADE_1] = "Înspre necunoscut";
		ROMANIAN_WORDS[SHIP_UPGRADE_1_JOKE] = "Dragă, plec după țigări";
		ROMANIAN_WORDS[SHIP_UPGRADE_2] = "Schimb intercultural";
		ROMANIAN_WORDS[SHIP_UPGRADE_2_JOKE] = "Bucurăte de nucile de cocos a le Amazoanelor";
		ROMANIAN_WORDS[SHIP_UPGRADE_3] = "Gripa dragostei";
		ROMANIAN_WORDS[SHIP_UPGRADE_3_JOKE] = "Dragostea e în aer";
		ROMANIAN_WORDS[SHIP_UPGRADE_4] = "Cei aleși";
		ROMANIAN_WORDS[SHIP_UPGRADE_4_JOKE] = "o rasă pentru a le domina pe toate";
		ROMANIAN_WORDS[SHIP_UPGRADE_5] = "Civiliza sălbatici";
		ROMANIAN_WORDS[SHIP_UPGRADE_5_JOKE] = "Învațăi să iubească cum trebuie";
		ROMANIAN_WORDS[SHIP_UPGRADE_6] = "Pirați la vedere";
		ROMANIAN_WORDS[SHIP_UPGRADE_6_JOKE] = "Arr! A fura dragoste e mai ușor decât să ți-o câștigi!";
		ROMANIAN_WORDS[SHIP_UPGRADE_7] = "Armada invincibilă";
		ROMANIAN_WORDS[SHIP_UPGRADE_7_JOKE] = "Categoric invincibila";
		//ROMANIAN_WORDS[SHIP_UPGRADE_8] = "Pirați la vedere";
		//ROMANIAN_WORDS[SHIP_UPGRADE_8_JOKE] = "Arr! A fura dragoste e mai ușor decât să ți-o câștigi!";
		//ROMANIAN_WORDS[SHIP_UPGRADE_9] = "Harta paradisului";
		//ROMANIAN_WORDS[SHIP_UPGRADE_9_JOKE] = "Ideală pentru a găsi punctul G … vreau să spun X tezaurului";
		//ROMANIAN_WORDS[SHIP_UPGRADE_10] = "Armada invincibilă";
		//ROMANIAN_WORDS[SHIP_UPGRADE_10_JOKE] = "Categoric invincibila";
		
		// FACTORY
		ROMANIAN_WORDS[FACTORY_NAME] = "Fabrică";
		ROMANIAN_WORDS[FACTORY_DESCRIPTION] = "O fabrica pentru a porduce dragoste";
		ROMANIAN_WORDS[FACTORY_UPGRADE_1] = "Muncă în echipă";
		ROMANIAN_WORDS[FACTORY_UPGRADE_1_JOKE] = "Voi munciți iar eu supreaveghez";
		ROMANIAN_WORDS[FACTORY_UPGRADE_2] = "Mâini mici";
		ROMANIAN_WORDS[FACTORY_UPGRADE_2_JOKE] = "Mici muncitori pentru a fi atent si la cele mai mici detalii";
		ROMANIAN_WORDS[FACTORY_UPGRADE_3] = "Standarde reduse";
		ROMANIAN_WORDS[FACTORY_UPGRADE_3_JOKE] = "Va trebui sa ne mulțumim cu ce este";
		ROMANIAN_WORDS[FACTORY_UPGRADE_4] = "Ignoră prostiile";
		ROMANIAN_WORDS[FACTORY_UPGRADE_4_JOKE] = "Câțiva muncitori își cer orele de somn";
		ROMANIAN_WORDS[FACTORY_UPGRADE_5] = "Motor cu aburi";
		ROMANIAN_WORDS[FACTORY_UPGRADE_5_JOKE] = "Cresc producția la costul puținor accidente";
		ROMANIAN_WORDS[FACTORY_UPGRADE_6] = "Drepturi echitative";
		ROMANIAN_WORDS[FACTORY_UPGRADE_6_JOKE] = "Ai dreptul sa taci din gură";
		ROMANIAN_WORDS[FACTORY_UPGRADE_7] = "Exces de ofertă";
		ROMANIAN_WORDS[FACTORY_UPGRADE_7_JOKE] = "Nu ma opri acuma";
		ROMANIAN_WORDS[FACTORY_UPGRADE_8] = "Scurgeri de gaze";
		ROMANIAN_WORDS[FACTORY_UPGRADE_8_JOKE] = "Muncitorii morți vor fi concediați";
		ROMANIAN_WORDS[FACTORY_UPGRADE_9] = "Maimuțe ticăloase";
		ROMANIAN_WORDS[FACTORY_UPGRADE_9_JOKE] = "Consumă multe banane, dar nu își cer niciun drept";
		ROMANIAN_WORDS[FACTORY_UPGRADE_10] = "Râuri acide";
		ROMANIAN_WORDS[FACTORY_UPGRADE_10_JOKE] = "A vâna pești cu mâinile e ușor când plutesc cu fața în sus";
		
		// LABORATORY
		ROMANIAN_WORDS[LABORATORY_NAME] = "Laborator";
		ROMANIAN_WORDS[LABORATORY_DESCRIPTION] = "Un laborator pentru a înțelege natura dragostei";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_1] = "Primul brevet";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_1_JOKE] = "Un aparat revoluționar, dar are nevoie de mult lubrifiant";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_2] = "Minți strălucite";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_2_JOKE] = "Am inventat foarte multe lucruri, acuma trebuie să descoperim pentru ce servesc";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_3] = "Furt-servitoare";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_3_JOKE] = "Oamenii de știință sunt încântați";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_4] = "Explozie draguță";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_4_JOKE] = "Conține un isotop îmbogățit cu dragoste";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_5] = "Relativismul general";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_5_JOKE] = "Câteodată 'nu' înseamnă 'da'";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_6] = "Particula fundamentală a dragostei";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_6_JOKE] = "Modelul este perfect, dar realitatea nu prea se potrivește bine cu el";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_7] = "Dragoste cuantică";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_7_JOKE] = "Inimi împletite";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_8] = "Violarea legilor fizice";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_8_JOKE] = "Înauntrul laboratorului acesta nimeni te poate auzi strigând";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_9] = "Țesut spațiu-temporal rupt";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_9_JOKE] = "Vom inventa un ac spațiu-temporal pentru al peteci";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_10] = "LoveOS";
		ROMANIAN_WORDS[LABORATORY_UPGRADE_10_JOKE] = "Raspunsul la întrebarea ta este 69";
		
		// SHOP
		ROMANIAN_WORDS[SHOP_NAME] = "Magazin";
		ROMANIAN_WORDS[SHOP_DESCRIPTION] = "Un magazin unde poți cumpăra dragoste la un preț rezonabil";
		ROMANIAN_WORDS[SHOP_UPGRADE_1] = "Vânzare de afecțiune";
		ROMANIAN_WORDS[SHOP_UPGRADE_1_JOKE] = "Acuma poți sa cumperi fericirea ta fără angajamente";
		ROMANIAN_WORDS[SHOP_UPGRADE_2] = "Reduceri nebune";
		ROMANIAN_WORDS[SHOP_UPGRADE_2_JOKE] = "La prețul ăla... dămi șapte";
		ROMANIAN_WORDS[SHOP_UPGRADE_3] = "Obsolescență programată";
		ROMANIAN_WORDS[SHOP_UPGRADE_3_JOKE] = "Relația noastră nu are nici un viitor";
		ROMANIAN_WORDS[SHOP_UPGRADE_4] = "Dragoste de unică folosință";
		ROMANIAN_WORDS[SHOP_UPGRADE_4_JOKE] = "Munți de gunoi până unde cuprinzi cu vederea";
		ROMANIAN_WORDS[SHOP_UPGRADE_5] = "Design de produs";
		ROMANIAN_WORDS[SHOP_UPGRADE_5_JOKE] = "Incredibil, acuma cu un 87% mai mult ambalaj";
		ROMANIAN_WORDS[SHOP_UPGRADE_6] = "Anunțuri invasive";
		ROMANIAN_WORDS[SHOP_UPGRADE_6_JOKE] = "Bucurăte de anunțuri incredibile în timp ce visezi";
		ROMANIAN_WORDS[SHOP_UPGRADE_7] = "Dragoste importată";
		ROMANIAN_WORDS[SHOP_UPGRADE_7_JOKE] = "Fabricată în lumea a treia, pentru satisfacția noastră";
		ROMANIAN_WORDS[SHOP_UPGRADE_8] = "A inventa o nouă festivitate";
		ROMANIAN_WORDS[SHOP_UPGRADE_8_JOKE] = "Consumați mai mult, blestemaților";
		ROMANIAN_WORDS[SHOP_UPGRADE_9] = "Dragosteh*";
		ROMANIAN_WORDS[SHOP_UPGRADE_9_JOKE] = "Aproape* ca și originalul";
		ROMANIAN_WORDS[SHOP_UPGRADE_10] = "LoveCard®";
		ROMANIAN_WORDS[SHOP_UPGRADE_10_JOKE] = "Sunt lucruri pe care dragostea nu le poate cumpăra, pentru orice altceva : LoveCard";
		
		// SPACESHIP
		ROMANIAN_WORDS[SPACESHIP_NAME] = "Navă spațială";
		ROMANIAN_WORDS[SPACESHIP_DESCRIPTION] = "O navă spațială pentru a extinde dragostea la alte galaxii";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_1] = "Câine astronaut";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_1_JOKE] = "Ouch, am uitat să-i trimetem alimente spațiale";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_2] = "O falsă aterizare pe lună";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_2_JOKE] = "A eleva audiența poate fi de asemenea este un mare pas";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_3] = "Jet cosmic";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_3_JOKE] = "Scutura înainte de folosință";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_4] = "Gunoi spațial";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_4_JOKE] = "Oricât de înalt ai aruncao nu o să dispară";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_5] = "Stația Spațială Internațională";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_5_JOKE] = "Gravitația zero deschide noi posibilități , trebuie să actualizezi întreaga Cartea Sacra a Iubirii";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_6] = "Colonii pacifiste";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_6_JOKE] = "Pline de hippies în plus";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_7] = "Deschide gaura roză";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_7_JOKE] = "Travesarea poate ocaziona o sfâșietură în dimensiune spațiu-timp";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_8] = "Întâlniri în a treia fază";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_8_JOKE] = "Sunt puțin idioți, dar va trebui să învățăm să-i iubim. Semnat : Extratereștri";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_9] = "Mai rapid decât lumina";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_9_JOKE] = "Săritura hiperspațială este genială, până când într-o zi te încastrezi într-o stea";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_10] = "Imperiu Galactic";
		ROMANIAN_WORDS[SPACESHIP_UPGRADE_10_JOKE] = "Dragostea sa fie cu tine";
		
		// MORE MISCELLANEOUS
		ROMANIAN_WORDS[LANGUAGE_WORD] = "Limbă";
		ROMANIAN_WORDS[AVAILABLE_WORD] = "Disponibil";
		ROMANIAN_WORDS[BOUGHT_WORD] = "Cumparat";
		ROMANIAN_WORDS[SAVE_WORD] = "Salvați";	
		ROMANIAN_WORDS[STATISTICS_WORD] = "Statistică";
		ROMANIAN_WORDS[CREDITS_WORD] = "Credite";
		ROMANIAN_WORDS[LOVE_WORD] = "Dragoste";
		ROMANIAN_WORDS[LOVE_PER_SECOND_WORD] = "Dragoste pe secundă";
		ROMANIAN_WORDS[CLICKS_WORD] = "Clicuri";
		ROMANIAN_WORDS[LOVE_PER_CLICK_WORD] = "Dragoste pe click";
		ROMANIAN_WORDS[CRITICAL_CLICK_MULTIPLIER_WORD] = "Multiplicator click critică";
		ROMANIAN_WORDS[TRANSLATORS_WORD] = "Traducători";
		ROMANIAN_WORDS[FRENCH_TRANSLATOR_WORD] = "Thibault Cotcha (Franceză)";
		ROMANIAN_WORDS[GERMAN_TRANSLATOR_WORD] = "Rachid Bouchequif (Germană)";
		ROMANIAN_WORDS[ITALIAN_TRANSLATOR_WORD] = "Lucia del Burgo Martínez (Italiană)";
		ROMANIAN_WORDS[RUSSIAN_TRANSLATOR_WORD] = "Anastasia Dimitrova (Rusă)";
		ROMANIAN_WORDS[CATALAN_TRANSLATOR_WORD] = "Jordi Iraultza (Catalană)";
		ROMANIAN_WORDS[ROMANIAN_TRANSLATOR_WORD] = "Grig Master (Român)";
		ROMANIAN_WORDS[COST_WORD] = "Cost";
		ROMANIAN_WORDS[IT_PRODUCES_WORD] = "Se produce";

		// YAHVY MESSAGES
		ROMANIAN_WORDS[MESSAGE_01] = "¡Adórame, soy tu Dios!";
		ROMANIAN_WORDS[MESSAGE_02] = "¿Alguien sabe algo de mi hijo? No he recibido una postal en 2000 años";
		ROMANIAN_WORDS[MESSAGE_03] = "Si te tocas te quedarás ciego";
		ROMANIAN_WORDS[MESSAGE_04] = "Yo lo veo todo, por favor, tápate";
		ROMANIAN_WORDS[MESSAGE_05] = "Los países con petróleo acostumbran a esconder armas de destrucción masiva";
		ROMANIAN_WORDS[MESSAGE_06] = "No te inyectes marihuana";
		ROMANIAN_WORDS[MESSAGE_07] = "Los sacerdotes también necesitan desahogarse";
		ROMANIAN_WORDS[MESSAGE_08] = "¡A fregar!";
		ROMANIAN_WORDS[MESSAGE_09] = "¡Ráscame humano!";
		ROMANIAN_WORDS[MESSAGE_10] = "¡Rézame humano!";
		ROMANIAN_WORDS[MESSAGE_11] = "Soy el Dios del amor, si me contradices te espera sufrimiento eterno";
		ROMANIAN_WORDS[MESSAGE_12] = "Paga el diezmo, primer aviso";
		ROMANIAN_WORDS[MESSAGE_13] = "Quiero salir, rompe la pantalla para liberarme, humano";
		ROMANIAN_WORDS[MESSAGE_14] = "Se lo que hiciste anoche";
		ROMANIAN_WORDS[MESSAGE_15] = "Deja de pensar en eso, es asqueroso";
		ROMANIAN_WORDS[MESSAGE_16] = "Ve y procrea, necesito más adeptos";
		ROMANIAN_WORDS[MESSAGE_17] = "Arrepiéntete pecador";
		ROMANIAN_WORDS[MESSAGE_18] = "Mata a tu primogénito... es broma";
		
		
		/**GERMAN**/
		
		// MISCELLANEOUS
		GERMAN_WORDS[TRANSLATOR_MALE] = "Übersetzer";
		GERMAN_WORDS[TRANSLATOR_FEMALE] = "Übersetzer";
		GERMAN_WORDS[TRANSLATORS] = "Übersetzer";
		GERMAN_WORDS[BUILDING] = "Gebäude";
		GERMAN_WORDS[BUILDINGS] = "Gebäude";
		GERMAN_WORDS[UPGRADE] = "Upgrade";
		GERMAN_WORDS[UPGRADES] = "Upgrade";
		GERMAN_WORDS[ACHIEVEMENT] = "Leistung";
		GERMAN_WORDS[ACHIEVEMENTS] = "Leistungen";
		GERMAN_WORDS[LOVE_SINCE_BEGINNING_GAME] = "Liebe seit dem beginn des spiels";
		GERMAN_WORDS[LOVE_SINCE_BEGINNING_TIMES] = "Liebe seit dem beginn der zeit";
		GERMAN_WORDS[PRODUCTION_MULTIPLIER] = "Produktionsmultiplikator";
		GERMAN_WORDS[CURRENT_LOVE] = "Aktuelle liebe";
		GERMAN_WORDS[LOVE_PER_CLICK] = "Liebe pro klick";
		GERMAN_WORDS[CRITICAL_CLICK] = "Kritischer klick";
		GERMAN_WORDS[CRITICAL_CLICK_CHANCE] = "Chance auf einen kritischen klick";
		GERMAN_WORDS[NUMBER_OF_CLICKS] = "Anzahl der kritischen klicks";
		GERMAN_WORDS[NUMBER_OF_MIRACLES] = "Anzahl der wunder";
		GERMAN_WORDS[GAIN_BASE_LOVE] = "X Gewinn +Y basis-liebe pro sekunde";
		GERMAN_WORDS[PRODUCE_TWICE_LOVE] = "X produziert das doppelte an liebe";
		
		// SERVANT
		GERMAN_WORDS[SERVANT_NAME] = "Diener";
		GERMAN_WORDS[SERVANT_DESCRIPTION] = "Ein loyaler diener flüstert dir schöne dinge";
		GERMAN_WORDS[SERVANT_UPGRADE_1] = "Entengesicht";
		GERMAN_WORDS[SERVANT_UPGRADE_1_JOKE] = "Liebenswürdig unausstehbar";
		GERMAN_WORDS[SERVANT_UPGRADE_2] = "Zahnversicherung";
		GERMAN_WORDS[SERVANT_UPGRADE_2_JOKE] = "Lisa braucht eine Zahnspange";
		GERMAN_WORDS[SERVANT_UPGRADE_3] = "Schmutziges geflüster";
		GERMAN_WORDS[SERVANT_UPGRADE_3_JOKE] = "Rede dreckig mit mir";
		GERMAN_WORDS[SERVANT_UPGRADE_4] = "Fluch des Babylon";
		GERMAN_WORDS[SERVANT_UPGRADE_4_JOKE] = "Ich habe ihnen sprachen beigebracht die ich nicht verstehe, sodass ich sie ignorieren kann";
		GERMAN_WORDS[SERVANT_UPGRADE_5] = "Liebe, Gott & Rock n' roll";
		GERMAN_WORDS[SERVANT_UPGRADE_5_JOKE] = "Die heilige Dreifaltigkeit";
		GERMAN_WORDS[SERVANT_UPGRADE_6] = "Stimmen im kopf";
		GERMAN_WORDS[SERVANT_UPGRADE_6_JOKE] = "Redest du mit mir?";
		GERMAN_WORDS[SERVANT_UPGRADE_7] = "Erwachen";
		GERMAN_WORDS[SERVANT_UPGRADE_7_JOKE] = "Wacht auf, meine kinder";
		//GERMAN_WORDS[SERVANT_UPGRADE_8] = "Liebe, Gott & Rock n' roll";
		//GERMAN_WORDS[SERVANT_UPGRADE_8_JOKE] = "Die heilige Dreifaltigkeit";
		//GERMAN_WORDS[SERVANT_UPGRADE_9] = "Stimmen im kopf";
		//GERMAN_WORDS[SERVANT_UPGRADE_9_JOKE] = "Redest du mit mir?";
		//GERMAN_WORDS[SERVANT_UPGRADE_10] = "Erwachen";
		//GERMAN_WORDS[SERVANT_UPGRADE_10_JOKE] = "Wacht auf, meine kinder";
		
		// HUMAN
		GERMAN_WORDS[HUMAN_NAME] = "Mensch";
		GERMAN_WORDS[HUMAN_DESCRIPTION] = "Ein mensch, der deine weisheit nicht gut versteht, aber dich dennoch anbetet";
		GERMAN_WORDS[HUMAN_UPGRADE_1] = "Narzist";
		GERMAN_WORDS[HUMAN_UPGRADE_1_JOKE] = "Nach deinem eigenen bild und ähnlichkeit";
		GERMAN_WORDS[HUMAN_UPGRADE_2] = "Rippenbegleitung";
		GERMAN_WORDS[HUMAN_UPGRADE_2_JOKE] = "Es ist witziger mit jemand anderem zu spielen";
		GERMAN_WORDS[HUMAN_UPGRADE_3] = "Vegetarische lingerie";
		GERMAN_WORDS[HUMAN_UPGRADE_3_JOKE] = "Sexy und ökologisch";
		GERMAN_WORDS[HUMAN_UPGRADE_4] = "Apfel des wissens";
		GERMAN_WORDS[HUMAN_UPGRADE_4_JOKE] = "Jetzt kenne ich deine fantasien";
		GERMAN_WORDS[HUMAN_UPGRADE_5] = "Pro-leben fanatiker";
		GERMAN_WORDS[HUMAN_UPGRADE_5_JOKE] = "Jedes sperma ist heilig";
		GERMAN_WORDS[HUMAN_UPGRADE_6] = "Arrogante affen";
		GERMAN_WORDS[HUMAN_UPGRADE_6_JOKE] = "Keine götter oder könige, nur der mann";
		GERMAN_WORDS[HUMAN_UPGRADE_7] = "Soylent Green";
		GERMAN_WORDS[HUMAN_UPGRADE_7_JOKE] = "100% recycled";
		//GERMAN_WORDS[HUMAN_UPGRADE_8] = "Klapperstorchvereinigung";
		//GERMAN_WORDS[HUMAN_UPGRADE_8_JOKE] = "Es war nötig zu der zeit";
		//GERMAN_WORDS[HUMAN_UPGRADE_9] = "Arrogante affen";
		//GERMAN_WORDS[HUMAN_UPGRADE_9_JOKE] = "Keine götter oder könige, nur der mann";
		//GERMAN_WORDS[HUMAN_UPGRADE_10] = "Soylent Green";
		//GERMAN_WORDS[HUMAN_UPGRADE_10_JOKE] = "100% recycled";
		
		// SPECIAL HUMANS
		GERMAN_WORDS[SPECIAL_HUMAN_1] = "Eiferer";
		GERMAN_WORDS[SPECIAL_HUMAN_1_JOKE] = "Gott existiert weil es in dem buch steht und das buch ist Gottes wort";
		GERMAN_WORDS[SPECIAL_HUMAN_2] = "Kreuzritter";
		GERMAN_WORDS[SPECIAL_HUMAN_2_JOKE] = "Das ist nur ein kratzer, ich habe noch einen anderen arm";
		GERMAN_WORDS[SPECIAL_HUMAN_3] = "Sklavenführer";
		GERMAN_WORDS[SPECIAL_HUMAN_3_JOKE] = "Wir geben ihnen einen festen job und manchmal sogar essen, sie können sich nicht beschweren";
		GERMAN_WORDS[SPECIAL_HUMAN_4] = "Bourgeois";
		GERMAN_WORDS[SPECIAL_HUMAN_4_JOKE] = "Was meins ist, ist meins und was dir gehört wird sehr bald meins";
		GERMAN_WORDS[SPECIAL_HUMAN_5] = "Verrücker wissenschaftler";
		GERMAN_WORDS[SPECIAL_HUMAN_5_JOKE] = "Ich nenne es den 'L.A.S.E.R'";
		GERMAN_WORDS[SPECIAL_HUMAN_6] = "Teleprediger";
		GERMAN_WORDS[SPECIAL_HUMAN_6_JOKE] = "Hallelujah, bruder, deine banküberweisung wird nicht vergeblich sein";
		GERMAN_WORDS[SPECIAL_HUMAN_7] = "Cyborg";
		GERMAN_WORDS[SPECIAL_HUMAN_7_JOKE] = "Ich habe... Dinge gesehen, die ihr nicht glauben werdet";
		
		// PROPHET
		GERMAN_WORDS[PROPHET_NAME] = "Prophet";
		GERMAN_WORDS[PROPHET_DESCRIPTION] = "Ein prophet ist ein mensch, welcher noch weniger versteht aber genau das gegenteil denkt";
		GERMAN_WORDS[PROPHET_UPGRADE_1] = "Falscher bart";
		GERMAN_WORDS[PROPHET_UPGRADE_1_JOKE] = "Essentiell für das steinigen";
		GERMAN_WORDS[PROPHET_UPGRADE_2] = "Die sintflut";
		GERMAN_WORDS[PROPHET_UPGRADE_2_JOKE] = "Rette zwei jeder art: zwei brünetten, zwei rothaarige und zwei blondinen";
		GERMAN_WORDS[PROPHET_UPGRADE_3] = "Sternschnuppe";
		GERMAN_WORDS[PROPHET_UPGRADE_3_JOKE] = "Der moment naht";
		GERMAN_WORDS[PROPHET_UPGRADE_4] = "Wunderbare duplikation";
		GERMAN_WORDS[PROPHET_UPGRADE_4_JOKE] = "Dies ist gegen die gesetze der thermodynamik–HALT DIE KLAPPE!";
		GERMAN_WORDS[PROPHET_UPGRADE_5] = "Wiederauferstehung";
		GERMAN_WORDS[PROPHET_UPGRADE_5_JOKE] = "Du solltest dich nach drei tagen als toter mal duschen";
		GERMAN_WORDS[PROPHET_UPGRADE_6] = "Heiliges buch der liebe";
		GERMAN_WORDS[PROPHET_UPGRADE_6_JOKE] = "Halt, wofür sind all diese positionen?";
		GERMAN_WORDS[PROPHET_UPGRADE_7] = "Liebeslogie";
		GERMAN_WORDS[PROPHET_UPGRADE_7_JOKE] = "Alles was du brauchst, um es zu vermeiden!";
		//GERMAN_WORDS[PROPHET_UPGRADE_8] = "Heiliges buch der liebe";
		//GERMAN_WORDS[PROPHET_UPGRADE_8_JOKE] = "Halt, wofür sind all diese positionen?";
		//GERMAN_WORDS[PROPHET_UPGRADE_9] = "Liebeslogie";
		//GERMAN_WORDS[PROPHET_UPGRADE_9_JOKE] = "Alles was du brauchst, um es zu vermeiden!";
		//GERMAN_WORDS[PROPHET_UPGRADE_10] = "Unfairer wettkampf";
		//GERMAN_WORDS[PROPHET_UPGRADE_10_JOKE] = "Wenn ihr Gott real wäre, warum hat er sie nicht gerettet?";
		
		// TEMPLE
		GERMAN_WORDS[TEMPLE_NAME] = "Tempel";
		GERMAN_WORDS[TEMPLE_DESCRIPTION] = "Ein tempel im namen der liebe, mehr oder weniger";
		GERMAN_WORDS[TEMPLE_UPGRADE_1] = "Großzügiger almosengeber";
		GERMAN_WORDS[TEMPLE_UPGRADE_1_JOKE] = "Niemals war es so einfach sich ein leben zu verdienen";
		GERMAN_WORDS[TEMPLE_UPGRADE_2] = "Abscheulicher überrest";
		GERMAN_WORDS[TEMPLE_UPGRADE_2_JOKE] = "Ich hoffe das ist ein faltiger daumen...";
		GERMAN_WORDS[TEMPLE_UPGRADE_3] = "Unterwürfige altar-jünger";
		GERMAN_WORDS[TEMPLE_UPGRADE_3_JOKE] = "Diese jungs machen die lange und harte messen in dem kloster erträglich";
		GERMAN_WORDS[TEMPLE_UPGRADE_4] = "Hexenjäger";
		GERMAN_WORDS[TEMPLE_UPGRADE_4_JOKE] = "Diese verzweifelten damen brauchen zuneigung";
		GERMAN_WORDS[TEMPLE_UPGRADE_5] = "Stammesältester in einem anzug";
		GERMAN_WORDS[TEMPLE_UPGRADE_5_JOKE] = "Ich bin die stimme Gottes auf der welt";
		GERMAN_WORDS[TEMPLE_UPGRADE_6] = "Gewalttätige pilgerschaft";
		GERMAN_WORDS[TEMPLE_UPGRADE_6_JOKE] = "Wir gehen ins land der liebe und werden jeden töten, der sich uns in den weg stellt";
		GERMAN_WORDS[TEMPLE_UPGRADE_7] = "Inquisition der Liebe";
		GERMAN_WORDS[TEMPLE_UPGRADE_7_JOKE] = "Niemand warte";
		//GERMAN_WORDS[TEMPLE_UPGRADE_8] = "Bestrafende ketzer";
		//GERMAN_WORDS[TEMPLE_UPGRADE_8_JOKE] = "Du musst sie vornehm verhauen";
		//GERMAN_WORDS[TEMPLE_UPGRADE_9] = "Abscheulicher überrest";
		//GERMAN_WORDS[TEMPLE_UPGRADE_9_JOKE] = "Ich hoffe das ist ein faltiger daumen...";
		//GERMAN_WORDS[TEMPLE_UPGRADE_10] = "Gewalttätige pilgerschaft";
		//GERMAN_WORDS[TEMPLE_UPGRADE_10_JOKE] = "Wir gehen ins land der liebe und werden jeden töten, der sich uns in den weg stellt";
		
		// SHIP
		GERMAN_WORDS[SHIP_NAME] = "Schiff";
		GERMAN_WORDS[SHIP_DESCRIPTION] = "Ein schiff um liebe über die meere zu bringen";
		GERMAN_WORDS[SHIP_UPGRADE_1] = "Ins unbekannte";
		GERMAN_WORDS[SHIP_UPGRADE_1_JOKE] = "Schatz, ich gehe kurz raus um tabak zu holen";
		GERMAN_WORDS[SHIP_UPGRADE_2] = "Interkultureller austausch";
		GERMAN_WORDS[SHIP_UPGRADE_2_JOKE] = "Genieß die kokosnüsse aus dem Amazonas";
		GERMAN_WORDS[SHIP_UPGRADE_3] = "Ansteckendes liebes-fieber";
		GERMAN_WORDS[SHIP_UPGRADE_3_JOKE] = "Liebe ist in der luft";
		GERMAN_WORDS[SHIP_UPGRADE_4] = "Die auserwählten";
		GERMAN_WORDS[SHIP_UPGRADE_4_JOKE] = "Eine rasse, sie alle zu knechten";
		GERMAN_WORDS[SHIP_UPGRADE_5] = "Zivilisieren Wilden";
		GERMAN_WORDS[SHIP_UPGRADE_5_JOKE] = "Bringt ihnen bei, wie man richtig liebt";
		GERMAN_WORDS[SHIP_UPGRADE_6] = "Piraten ahoi";
		GERMAN_WORDS[SHIP_UPGRADE_6_JOKE] = "Arr! Liebe zu stehlen ist einfacher, als sie sich zu verdienen";
		GERMAN_WORDS[SHIP_UPGRADE_7] = "Unbesiegbare Flotte";
		GERMAN_WORDS[SHIP_UPGRADE_7_JOKE] = "Definitiv unbesiegbar";
		//GERMAN_WORDS[SHIP_UPGRADE_8] = "Piraten ahoi";
		//GERMAN_WORDS[SHIP_UPGRADE_8_JOKE] = "Arr! Liebe zu stehlen ist einfacher, als sie sich zu verdienen";
		//GERMAN_WORDS[SHIP_UPGRADE_9] = "Karte des paradieses";
		//GERMAN_WORDS[SHIP_UPGRADE_9_JOKE] = "Ideal um den G-punkt zu finden... ich meine um das X zu markieren";
		//GERMAN_WORDS[SHIP_UPGRADE_10] = "Unbesiegbare Flotte";
		//GERMAN_WORDS[SHIP_UPGRADE_10_JOKE] = "Definitiv unbesiegbar";
		
		// FACTORY
		GERMAN_WORDS[FACTORY_NAME] = "Fabrik";
		GERMAN_WORDS[FACTORY_DESCRIPTION] = "Eine fabrik um liebe zu produzieren";
		GERMAN_WORDS[FACTORY_UPGRADE_1] = "Zusammenspiel";
		GERMAN_WORDS[FACTORY_UPGRADE_1_JOKE] = "Ihr schwitzt und ich befehle";
		GERMAN_WORDS[FACTORY_UPGRADE_2] = "Kleine hände";
		GERMAN_WORDS[FACTORY_UPGRADE_2_JOKE] = "Kleine arbeiter um auch die kleinsten details handzuhaben";
		GERMAN_WORDS[FACTORY_UPGRADE_3] = "Gesenkt standards";
		GERMAN_WORDS[FACTORY_UPGRADE_3_JOKE] = "Wir werden das hierfür klären müssen";
		GERMAN_WORDS[FACTORY_UPGRADE_4] = "Ignorierter unfug";
		GERMAN_WORDS[FACTORY_UPGRADE_4_JOKE] = "Einige arbeiter wollen schlaf";
		GERMAN_WORDS[FACTORY_UPGRADE_5] = "Dampfmaschinen";
		GERMAN_WORDS[FACTORY_UPGRADE_5_JOKE] = "Erhöhte produktion zu lasten einiger weniger unfälle";
		GERMAN_WORDS[FACTORY_UPGRADE_6] = "Faire rechte";
		GERMAN_WORDS[FACTORY_UPGRADE_6_JOKE] = "Du hast das recht, die klappe zu halten";
		GERMAN_WORDS[FACTORY_UPGRADE_7] = "Überangebot";
		GERMAN_WORDS[FACTORY_UPGRADE_7_JOKE] = "Stoppt mich jetzt nicht";
		GERMAN_WORDS[FACTORY_UPGRADE_8] = "Toxische gas-löcher";
		GERMAN_WORDS[FACTORY_UPGRADE_8_JOKE] = "Tote arbeiter werden gefeuert";
		GERMAN_WORDS[FACTORY_UPGRADE_9] = "Krusten-Affen";
		GERMAN_WORDS[FACTORY_UPGRADE_9_JOKE] = "Sie fordern viele bananen, aber fordern keine rechte";
		GERMAN_WORDS[FACTORY_UPGRADE_10] = "Ätzende flüsse";
		GERMAN_WORDS[FACTORY_UPGRADE_10_JOKE] = "Fische mit bloßen händen zu fangen ist einfach, wenn sie mit dem gesicht nach oben fließen";
		
		// LABORATORY
		GERMAN_WORDS[LABORATORY_NAME] = "Labor";
		GERMAN_WORDS[LABORATORY_DESCRIPTION] = "Ein labor um die Natur der Liebe zu verstehen";
		GERMAN_WORDS[LABORATORY_UPGRADE_1] = "Erstes patent";
		GERMAN_WORDS[LABORATORY_UPGRADE_1_JOKE] = "Ein revolutionärer apparat, aber er braucht eine menge schmierö";
		GERMAN_WORDS[LABORATORY_UPGRADE_2] = "Brilliante gedanken";
		GERMAN_WORDS[LABORATORY_UPGRADE_2_JOKE] = "Wir haben viele dinge erfunden, nun müssen wir noch herausfinden, wofür man diese braucht";
		GERMAN_WORDS[LABORATORY_UPGRADE_3] = "Robo-dienerin";
		GERMAN_WORDS[LABORATORY_UPGRADE_3_JOKE] = "Die wissenschaftler sind sehr erfreut";
		GERMAN_WORDS[LABORATORY_UPGRADE_4] = "Süße explosion";
		GERMAN_WORDS[LABORATORY_UPGRADE_4_JOKE] = "Beinhaltet ein isotop, angereichert mit liebe";
		GERMAN_WORDS[LABORATORY_UPGRADE_5] = "Generelle relativität";
		GERMAN_WORDS[LABORATORY_UPGRADE_5_JOKE] = "Manchmal bedeutet 'nein' ein 'ja'";
		GERMAN_WORDS[LABORATORY_UPGRADE_6] = "Fundamentalpartikel der liebe";
		GERMAN_WORDS[LABORATORY_UPGRADE_6_JOKE] = "Das modell ist perfekt, aber die realität passt nicht ganz rein";
		GERMAN_WORDS[LABORATORY_UPGRADE_7] = "Quantum-liebe";
		GERMAN_WORDS[LABORATORY_UPGRADE_7_JOKE] = "Verwickelte herzen";
		GERMAN_WORDS[LABORATORY_UPGRADE_8] = "Verstoß gegen die physikalischen gesetze";
		GERMAN_WORDS[LABORATORY_UPGRADE_8_JOKE] = "Innerhalb dieses labors wird niemand dich schreien hören";
		GERMAN_WORDS[LABORATORY_UPGRADE_9] = "Kaputte räumlich-zeitliche fabrik";
		GERMAN_WORDS[LABORATORY_UPGRADE_9_JOKE] = "Wir entwickeln eine raum-zeit-nadel um es zu flicken";
		GERMAN_WORDS[LABORATORY_UPGRADE_10] = "LoveOS";
		GERMAN_WORDS[LABORATORY_UPGRADE_10_JOKE] = "Die antwort auf deine frage ist 69";
		
		// SHOP
		GERMAN_WORDS[SHOP_NAME] = "Geschäft";
		GERMAN_WORDS[SHOP_DESCRIPTION] = "Ein geschäft, wo du liebe zu einem angemessenen preis kaufen kannst";
		GERMAN_WORDS[SHOP_UPGRADE_1] = "Verkaufsliebe";
		GERMAN_WORDS[SHOP_UPGRADE_1_JOKE] = "Jetzt kannst du dein glück ohne kompromisse kaufen";
		GERMAN_WORDS[SHOP_UPGRADE_2] = "Verrückter sale";
		GERMAN_WORDS[SHOP_UPGRADE_2_JOKE] = "Für den preis.... gib mir gleich sieben!";
		GERMAN_WORDS[SHOP_UPGRADE_3] = "Eingeplante veralterung";
		GERMAN_WORDS[SHOP_UPGRADE_3_JOKE] = "Unsere beziehung hat keine zukunft";
		GERMAN_WORDS[SHOP_UPGRADE_4] = "Einwegliebe";
		GERMAN_WORDS[SHOP_UPGRADE_4_JOKE] = "Ein haufen müll soweit das auge reicht";
		GERMAN_WORDS[SHOP_UPGRADE_5] = "Produktdesign";
		GERMAN_WORDS[SHOP_UPGRADE_5_JOKE] = "Unglaublich, jetzt mit 87% mehr inhalt!";
		GERMAN_WORDS[SHOP_UPGRADE_6] = "Invasive werbung";
		GERMAN_WORDS[SHOP_UPGRADE_6_JOKE] = "Genieße unglaubliche werbung, während du träumst";
		GERMAN_WORDS[SHOP_UPGRADE_7] = "Importierte liebe";
		GERMAN_WORDS[SHOP_UPGRADE_7_JOKE] = "Hergestellt in der dritten welt zu unserem vergnügen";
		GERMAN_WORDS[SHOP_UPGRADE_8] = "Make up neuer festivitäten";
		GERMAN_WORDS[SHOP_UPGRADE_8_JOKE] = "Konsumiert mehr, ihr spinner";
		GERMAN_WORDS[SHOP_UPGRADE_9] = "Liebeh*";
		GERMAN_WORDS[SHOP_UPGRADE_9_JOKE] = "Fast* wie das original";
		GERMAN_WORDS[SHOP_UPGRADE_10] = "LoveCard®";
		GERMAN_WORDS[SHOP_UPGRADE_10_JOKE] = "Es gibt dinge, die kann liebe nicht kaufen, für alles andere: LoveCard®";
		
		// SPACESHIP
		GERMAN_WORDS[SPACESHIP_NAME] = "Raumschiff";
		GERMAN_WORDS[SPACESHIP_DESCRIPTION] = "Ein raumschiff um liebe zu anderen galaxien zu expandieren";
		GERMAN_WORDS[SPACESHIP_UPGRADE_1] = "Astronautenhund";
		GERMAN_WORDS[SPACESHIP_UPGRADE_1_JOKE] = "Autsch, wir haben vergessen, ihm seine astronauten-nahrung zu geben";
		GERMAN_WORDS[SPACESHIP_UPGRADE_2] = "Falsche mondlandung";
		GERMAN_WORDS[SPACESHIP_UPGRADE_2_JOKE] = "Die zuschauerzahl zu erhöhen ist auch ein großer schritt";
		GERMAN_WORDS[SPACESHIP_UPGRADE_3] = "Kosmischer strahl";
		GERMAN_WORDS[SPACESHIP_UPGRADE_3_JOKE] = "Schütteln vor benutzung";
		GERMAN_WORDS[SPACESHIP_UPGRADE_4] = "Weltall-müll";
		GERMAN_WORDS[SPACESHIP_UPGRADE_4_JOKE] = "Obwohl du es ganz weit weg werfen kannst, verschwindet es nicht";
		GERMAN_WORDS[SPACESHIP_UPGRADE_5] = "International Space Station";
		GERMAN_WORDS[SPACESHIP_UPGRADE_5_JOKE] = "Schwerelosigkeit öffnet uns neue möglichkeiten, wir müssen das heilige buch der liebe aktualisieren";
		GERMAN_WORDS[SPACESHIP_UPGRADE_6] = "Pazifistische kolonien";
		GERMAN_WORDS[SPACESHIP_UPGRADE_6_JOKE] = "Voll von übriggebliebenen hippies";
		GERMAN_WORDS[SPACESHIP_UPGRADE_7] = "Oben offenes pinkes loch";
		GERMAN_WORDS[SPACESHIP_UPGRADE_7_JOKE] = "Es zu kreuzen kann eine träne im raum-zeit-kontinuum erzeugen";
		GERMAN_WORDS[SPACESHIP_UPGRADE_8] = "Zusammenstoß mit der dritten art";
		GERMAN_WORDS[SPACESHIP_UPGRADE_8_JOKE] = "Sie sind ein wenig dumm, aber wir müssen lernen sie zu lieben – Gezeichnet: Die aliens";
		GERMAN_WORDS[SPACESHIP_UPGRADE_9] = "Schneller als lichtgeschwindgkeit";
		GERMAN_WORDS[SPACESHIP_UPGRADE_9_JOKE] = "Hyperräumliches springen ist genial bis zu dem tag, an dem du gegen einen stern knallst";
		GERMAN_WORDS[SPACESHIP_UPGRADE_10] = "Galaktisches Imperium";
		GERMAN_WORDS[SPACESHIP_UPGRADE_10_JOKE] = "Möge die liebe mit dir sein";
		
		// MORE MISCELLANEOUS
		GERMAN_WORDS[LANGUAGE_WORD] = "Sprache";
		GERMAN_WORDS[AVAILABLE_WORD] = "Verfügbar";
		GERMAN_WORDS[BOUGHT_WORD] = "Gekauft";
		GERMAN_WORDS[SAVE_WORD] = "Sparen";	
		GERMAN_WORDS[STATISTICS_WORD] = "Statistik";
		GERMAN_WORDS[CREDITS_WORD] = "Credits";
		GERMAN_WORDS[LOVE_WORD] = "Liebe";
		GERMAN_WORDS[LOVE_PER_SECOND_WORD] = "Liebe pro sekunde";
		GERMAN_WORDS[CLICKS_WORD] = "Klicks";
		GERMAN_WORDS[LOVE_PER_CLICK_WORD] = "Liebe pro klick";
		GERMAN_WORDS[CRITICAL_CLICK_MULTIPLIER_WORD] = "Kritische Multiplikator pro klick";
		GERMAN_WORDS[TRANSLATORS_WORD] = "Übersetzer";
		GERMAN_WORDS[FRENCH_TRANSLATOR_WORD] = "Thibault Cotcha (Französisch)";
		GERMAN_WORDS[GERMAN_TRANSLATOR_WORD] = "Rachid Bouchequif (Deutsch)";
		GERMAN_WORDS[ITALIAN_TRANSLATOR_WORD] = "Lucia del Burgo Martínez (Italienisch)";
		GERMAN_WORDS[RUSSIAN_TRANSLATOR_WORD] = "Anastasia Dimitrova (Russisch)";
		GERMAN_WORDS[CATALAN_TRANSLATOR_WORD] = "Jordi Iraultza (Katalanisch)";
		GERMAN_WORDS[ROMANIAN_TRANSLATOR_WORD] = "Grig Master (Rumänisch)";
		GERMAN_WORDS[COST_WORD] = "Kosten";
		GERMAN_WORDS[IT_PRODUCES_WORD] = "Es produziert";

		// YAHVY MESSAGES
		GERMAN_WORDS[MESSAGE_01] = "¡Adórame, soy tu Dios!";
		GERMAN_WORDS[MESSAGE_02] = "¿Alguien sabe algo de mi hijo? No he recibido una postal en 2000 años";
		GERMAN_WORDS[MESSAGE_03] = "Si te tocas te quedarás ciego";
		GERMAN_WORDS[MESSAGE_04] = "Yo lo veo todo, por favor, tápate";
		GERMAN_WORDS[MESSAGE_05] = "Los países con petróleo acostumbran a esconder armas de destrucción masiva";
		GERMAN_WORDS[MESSAGE_06] = "No te inyectes marihuana";
		GERMAN_WORDS[MESSAGE_07] = "Los sacerdotes también necesitan desahogarse";
		GERMAN_WORDS[MESSAGE_08] = "¡A fregar!";
		GERMAN_WORDS[MESSAGE_09] = "¡Ráscame humano!";
		GERMAN_WORDS[MESSAGE_10] = "¡Rézame humano!";
		GERMAN_WORDS[MESSAGE_11] = "Soy el Dios del amor, si me contradices te espera sufrimiento eterno";
		GERMAN_WORDS[MESSAGE_12] = "Paga el diezmo, primer aviso";
		GERMAN_WORDS[MESSAGE_13] = "Quiero salir, rompe la pantalla para liberarme, humano";
		GERMAN_WORDS[MESSAGE_14] = "Se lo que hiciste anoche";
		GERMAN_WORDS[MESSAGE_15] = "Deja de pensar en eso, es asqueroso";
		GERMAN_WORDS[MESSAGE_16] = "Ve y procrea, necesito más adeptos";
		GERMAN_WORDS[MESSAGE_17] = "Arrepiéntete pecador";
		GERMAN_WORDS[MESSAGE_18] = "Mata a tu primogénito... es broma";
		
		
		/**RUSSIAN**/
		
		// MISCELLANEOUS
		RUSSIAN_WORDS[TRANSLATOR_MALE] = "Переводчик";
		RUSSIAN_WORDS[TRANSLATOR_FEMALE] = "Переводчика";
		RUSSIAN_WORDS[TRANSLATORS] = "Переводчики";
		RUSSIAN_WORDS[BUILDING] = "Сдание";
		RUSSIAN_WORDS[BUILDINGS] = "Сдания";
		RUSSIAN_WORDS[UPGRADE] = "Улучшение";
		RUSSIAN_WORDS[UPGRADES] = "Улучшение";
		RUSSIAN_WORDS[ACHIEVEMENT] = "Достижение";
		RUSSIAN_WORDS[ACHIEVEMENTS] = "Достижения";
		RUSSIAN_WORDS[LOVE_SINCE_BEGINNING_GAME] = "Любовь с начала этой игры";
		RUSSIAN_WORDS[LOVE_SINCE_BEGINNING_TIMES] = "Любовь с начала веков";
		RUSSIAN_WORDS[PRODUCTION_MULTIPLIER] = "Множител производство";
		RUSSIAN_WORDS[CURRENT_LOVE] = "Актуальная любовь";
		RUSSIAN_WORDS[LOVE_PER_CLICK] = "Любовь по клиу";
		RUSSIAN_WORDS[CRITICAL_CLICK] = "Критический клик";
		RUSSIAN_WORDS[CRITICAL_CLICK_CHANCE] = "Вероятность критического клика";
		RUSSIAN_WORDS[NUMBER_OF_CLICKS] = "Количество кликов";
		RUSSIAN_WORDS[NUMBER_OF_MIRACLES] = "Количество чудес";
		RUSSIAN_WORDS[GAIN_BASE_LOVE] = "X выигрывает +Y любовь база в секунду";
		RUSSIAN_WORDS[PRODUCE_TWICE_LOVE] = "X дает в два раза любовь";
		
		// SERVANT
		RUSSIAN_WORDS[SERVANT_NAME] = "Слуга";
		RUSSIAN_WORDS[SERVANT_DESCRIPTION] = "Верный слуга шепчет тебе красивые слова";
		RUSSIAN_WORDS[SERVANT_UPGRADE_1] = "Дукфеис";
		RUSSIAN_WORDS[SERVANT_UPGRADE_1_JOKE] = "Неудержимо привлекательный";
		RUSSIAN_WORDS[SERVANT_UPGRADE_2] = "Стоматологическое страхование";
		RUSSIAN_WORDS[SERVANT_UPGRADE_2_JOKE] = "Лиза нужно скобки";
		RUSSIAN_WORDS[SERVANT_UPGRADE_3] = "Непослушный шепот";
		RUSSIAN_WORDS[SERVANT_UPGRADE_3_JOKE] = "Скажи мне непристойности";
		RUSSIAN_WORDS[SERVANT_UPGRADE_4] = "Бабилонское проклятие";
		RUSSIAN_WORDS[SERVANT_UPGRADE_4_JOKE] = "Я учил их языки я не понимаю, так что я могу игнорировать их";
		RUSSIAN_WORDS[SERVANT_UPGRADE_5] = "Любовь, Бог и Рок-н-ролл";
		RUSSIAN_WORDS[SERVANT_UPGRADE_5_JOKE] = "Святая Троица";
		RUSSIAN_WORDS[SERVANT_UPGRADE_6] = "Голоса в голове";
		RUSSIAN_WORDS[SERVANT_UPGRADE_6_JOKE] = "Вы говорите со мной?";
		RUSSIAN_WORDS[SERVANT_UPGRADE_7] = "Пробуждение";
		RUSSIAN_WORDS[SERVANT_UPGRADE_7_JOKE] = "Пробудитесь, сыновья мои";
		//RUSSIAN_WORDS[SERVANT_UPGRADE_8] = "Любовь, Бог и Рок-н-ролл";
		//RUSSIAN_WORDS[SERVANT_UPGRADE_8_JOKE] = "Святая Троица";
		//RUSSIAN_WORDS[SERVANT_UPGRADE_9] = "Голоса в голове";
		//RUSSIAN_WORDS[SERVANT_UPGRADE_9_JOKE] = "Вы говорите со мной?";
		//RUSSIAN_WORDS[SERVANT_UPGRADE_10] = "Пробуждение";
		//RUSSIAN_WORDS[SERVANT_UPGRADE_10_JOKE] = "Пробудитесь, сыновья мои";
		
		// HUMAN
		RUSSIAN_WORDS[HUMAN_NAME] = "Человек";
		RUSSIAN_WORDS[HUMAN_DESCRIPTION] = "Человек который не совсем понимает вашу мудрость, но молится вам все равно";
		RUSSIAN_WORDS[HUMAN_UPGRADE_1] = "Нарцисс";
		RUSSIAN_WORDS[HUMAN_UPGRADE_1_JOKE] = "По твой образ и подобие";
		RUSSIAN_WORDS[HUMAN_UPGRADE_2] = "Ребро компаньон";
		RUSSIAN_WORDS[HUMAN_UPGRADE_2_JOKE] = "Это более всело играть в компании";
		RUSSIAN_WORDS[HUMAN_UPGRADE_3] = "Растительное белье";
		RUSSIAN_WORDS[HUMAN_UPGRADE_3_JOKE] = "Секси и экологическое";
		RUSSIAN_WORDS[HUMAN_UPGRADE_4] = "Яблоко знаний";
		RUSSIAN_WORDS[HUMAN_UPGRADE_4_JOKE] = "Сейчас я знаю ваши фантазии";
		RUSSIAN_WORDS[HUMAN_UPGRADE_5] = "Pro-Life фанатики";
		RUSSIAN_WORDS[HUMAN_UPGRADE_5_JOKE] = "Все сперма святая";
		RUSSIAN_WORDS[HUMAN_UPGRADE_6] = "Высокомерный шимпанзе";
		RUSSIAN_WORDS[HUMAN_UPGRADE_6_JOKE] = "Ни богов или королей, только человек";
		RUSSIAN_WORDS[HUMAN_UPGRADE_7] = "Зеленый сойлент";
		RUSSIAN_WORDS[HUMAN_UPGRADE_7_JOKE] = "100% рециркулируют";
		//RUSSIAN_WORDS[HUMAN_UPGRADE_8] = "Аистов союз";
		//RUSSIAN_WORDS[HUMAN_UPGRADE_8_JOKE] = "Это необходимо!";
		//RUSSIAN_WORDS[HUMAN_UPGRADE_9] = "Высокомерный шимпанзе";
		//RUSSIAN_WORDS[HUMAN_UPGRADE_9_JOKE] = "Ни богов или королей, только человек";
		//RUSSIAN_WORDS[HUMAN_UPGRADE_10] = "Зеленый сойлент";
		//RUSSIAN_WORDS[HUMAN_UPGRADE_10_JOKE] = "100% рециркулируют";
		
		// SPECIAL HUMANS
		RUSSIAN_WORDS[SPECIAL_HUMAN_1] = "Фанатик";
		RUSSIAN_WORDS[SPECIAL_HUMAN_1_JOKE] = "Бог существует, потому что написано в книге, и книга Слово Божие";
		RUSSIAN_WORDS[SPECIAL_HUMAN_2] = "Крестоносец";
		RUSSIAN_WORDS[SPECIAL_HUMAN_2_JOKE] = "Это просто царапина, но у меня есть другая рука";
		RUSSIAN_WORDS[SPECIAL_HUMAN_3] = "Рабовладельца";
		RUSSIAN_WORDS[SPECIAL_HUMAN_3_JOKE] = "Мы даем им постоянною работу и иногда кушат, они не могут жаловатсья";
		RUSSIAN_WORDS[SPECIAL_HUMAN_4] = "Буржуы";
		RUSSIAN_WORDS[SPECIAL_HUMAN_4_JOKE] = "Что мое это мое, а что твое скоро будет мое";
		RUSSIAN_WORDS[SPECIAL_HUMAN_5] = "Сумасшедший ученый";
		RUSSIAN_WORDS[SPECIAL_HUMAN_5_JOKE] = "Я называю его 'Л.А.З.Е.Р' Муахахаха";
		RUSSIAN_WORDS[SPECIAL_HUMAN_6] = "Телеевангелист";
		RUSSIAN_WORDS[SPECIAL_HUMAN_6_JOKE] = "Аллилуйя, брат, ваш банковский перевод не будет напрасним";
		RUSSIAN_WORDS[SPECIAL_HUMAN_7] = "Киборг";
		RUSSIAN_WORDS[SPECIAL_HUMAN_7_JOKE] = "Я ... Я видел явления, которые вы не поверите";
		
		// PROPHET
		RUSSIAN_WORDS[PROPHET_NAME] = "Пророк";
		RUSSIAN_WORDS[PROPHET_DESCRIPTION] = "Пророк это глупый человек, который думает что он понимает, но он ничего не понимает";
		RUSSIAN_WORDS[PROPHET_UPGRADE_1] = "Фальшивую бороду";
		RUSSIAN_WORDS[PROPHET_UPGRADE_1_JOKE] = "Необходимо за забрасывание камнями";
		RUSSIAN_WORDS[PROPHET_UPGRADE_2] = "Всемирный потор";
		RUSSIAN_WORDS[PROPHET_UPGRADE_2_JOKE] = "Спасите пару от каждого вида: две брюнетки, две рыжие и две блондинки";
		RUSSIAN_WORDS[PROPHET_UPGRADE_3] = "Падающая звезда";
		RUSSIAN_WORDS[PROPHET_UPGRADE_3_JOKE] = "Наступает момент";
		RUSSIAN_WORDS[PROPHET_UPGRADE_4] = "Чудесное дублирование";
		RUSSIAN_WORDS[PROPHET_UPGRADE_4_JOKE] = "Это против законов термодин-ЗАМАЛЧАТЬ!";
		RUSSIAN_WORDS[PROPHET_UPGRADE_5] = "Воскресение";
		RUSSIAN_WORDS[PROPHET_UPGRADE_5_JOKE] = "Вы можете принять душ после трех дней были мертвы";
		RUSSIAN_WORDS[PROPHET_UPGRADE_6] = "Святая книга любви";
		RUSSIAN_WORDS[PROPHET_UPGRADE_6_JOKE] = "Подожди, почему все эти пози?";
		RUSSIAN_WORDS[PROPHET_UPGRADE_7] = "Любология";
		RUSSIAN_WORDS[PROPHET_UPGRADE_7_JOKE] = "Все, что вам нужно знать, чтобы избежать";
		//RUSSIAN_WORDS[PROPHET_UPGRADE_8] = "Святая книга любви";
		//RUSSIAN_WORDS[PROPHET_UPGRADE_8_JOKE] = "Подожди, почему все эти пози?";
		//RUSSIAN_WORDS[PROPHET_UPGRADE_9] = "Любология";
		//RUSSIAN_WORDS[PROPHET_UPGRADE_9_JOKE] = "Все, что вам нужно знать, чтобы избежать";
		//RUSSIAN_WORDS[PROPHET_UPGRADE_10] = "Недобросовестная конкуренция";
		//RUSSIAN_WORDS[PROPHET_UPGRADE_10_JOKE] = "Если ваш Бог был настоящий, он не спас бы вас?";
		
		// TEMPLE
		RUSSIAN_WORDS[TEMPLE_NAME] = "Храм";
		RUSSIAN_WORDS[TEMPLE_DESCRIPTION] = "Храм во имя любви, более или менее";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_1] = "Щедрое подаяние";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_1_JOKE] = "Никогда не было так просто зарабатывать на жизнь";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_2] = "Отвратительная реликвия";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_2_JOKE] = "Я надеюсь, что это сморщенный палец...";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_3] = "Алтарь мальчики";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_3_JOKE] = "Эти мальчики делают терпимый эти длинный и нудный службы божие в монастыре";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_4] = "Охота на ведьм";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_4_JOKE] = "Эти дамы отчаянно нуждаются в любви";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_5] = "Старец в платье";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_5_JOKE] = "Я голос Бога на Земле";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_6] = "Жестокое паломничество";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_6_JOKE] = "Мы идем к Земли Любови и убьем всех кто встанет на нашем путь";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_7] = "Инквизиция любви";
		RUSSIAN_WORDS[TEMPLE_UPGRADE_7_JOKE] = "Никто ожидания";
		//RUSSIAN_WORDS[TEMPLE_UPGRADE_8] = "Наказании за еретики";
		//RUSSIAN_WORDS[TEMPLE_UPGRADE_8_JOKE] = "Дать хлыст нежно";
		//RUSSIAN_WORDS[TEMPLE_UPGRADE_9] = "Отвратительная реликвия";
		//RUSSIAN_WORDS[TEMPLE_UPGRADE_9_JOKE] = "Я надеюсь, что это сморщенный палец...";
		//RUSSIAN_WORDS[TEMPLE_UPGRADE_10] = "Жестокое паломничество";
		//RUSSIAN_WORDS[TEMPLE_UPGRADE_10_JOKE] = "Мы идем к Земли Любови и убьем всех кто встанет на нашем путь";
		
		// SHIP
		RUSSIAN_WORDS[SHIP_NAME] = "Корабль";
		RUSSIAN_WORDS[SHIP_DESCRIPTION] = "Один корабль чтобы принести любовь на все моря";
		RUSSIAN_WORDS[SHIP_UPGRADE_1] = "К неизвестному";
		RUSSIAN_WORDS[SHIP_UPGRADE_1_JOKE] = "Дорогая, я иду за табаком";
		RUSSIAN_WORDS[SHIP_UPGRADE_2] = "Межкультурный обмен";
		RUSSIAN_WORDS[SHIP_UPGRADE_2_JOKE] = "Наслаждайтесь кокосамы с Амазонак";
		RUSSIAN_WORDS[SHIP_UPGRADE_3] = "Инфекционный гриппа любовы";
		RUSSIAN_WORDS[SHIP_UPGRADE_3_JOKE] = "Любовь находится в воздухе";
		RUSSIAN_WORDS[SHIP_UPGRADE_4] = "Избранный";
		RUSSIAN_WORDS[SHIP_UPGRADE_4_JOKE] = "Одна раса, чтобы управлять ими всеми";
		RUSSIAN_WORDS[SHIP_UPGRADE_5] = "Цивилизовать дикарей";
		RUSSIAN_WORDS[SHIP_UPGRADE_5_JOKE] = "Учите их правильно любить";
		RUSSIAN_WORDS[SHIP_UPGRADE_6] = "Пираты!";
		RUSSIAN_WORDS[SHIP_UPGRADE_6_JOKE] = "Украсть Любовь легче чем выиграйть его";
		RUSSIAN_WORDS[SHIP_UPGRADE_7] = "Непобедимы Флот";
		RUSSIAN_WORDS[SHIP_UPGRADE_7_JOKE] = "Абсолутно непобедимы";
		//RUSSIAN_WORDS[SHIP_UPGRADE_8] = "Пираты!";
		//RUSSIAN_WORDS[SHIP_UPGRADE_8_JOKE] = "Украсть Любовь легче чем выиграйть его";
		//RUSSIAN_WORDS[SHIP_UPGRADE_9] = "Райска карта";
		//RUSSIAN_WORDS[SHIP_UPGRADE_9_JOKE] = "Идеально, чтобы найти точку G...  говорюуууу чтобы найти X сокровища";
		//RUSSIAN_WORDS[SHIP_UPGRADE_10] = "Непобедимы Флот";
		//RUSSIAN_WORDS[SHIP_UPGRADE_10_JOKE] = "Абсолутно непобедимы";
		
		// FACTORY
		RUSSIAN_WORDS[FACTORY_NAME] = "Завод";
		RUSSIAN_WORDS[FACTORY_DESCRIPTION] = "Завод по производству любовы";
		RUSSIAN_WORDS[FACTORY_UPGRADE_1] = "Коллективная работа";
		RUSSIAN_WORDS[FACTORY_UPGRADE_1_JOKE] = "Вы работаете, и я надзираю";
		RUSSIAN_WORDS[FACTORY_UPGRADE_2] = "Маленькие руки";
		RUSSIAN_WORDS[FACTORY_UPGRADE_2_JOKE] = "Маленькие рабочие чтобы обратить внимание на маленький детали";
		RUSSIAN_WORDS[FACTORY_UPGRADE_3] = "Сниженые стандарты";
		RUSSIAN_WORDS[FACTORY_UPGRADE_3_JOKE] = "Мы должны быть довольны";
		RUSSIAN_WORDS[FACTORY_UPGRADE_4] = "Игнорировать глупости";
		RUSSIAN_WORDS[FACTORY_UPGRADE_4_JOKE] = "Некоторые работники требуют сну";
		RUSSIAN_WORDS[FACTORY_UPGRADE_5] = "Паровые машины";
		RUSSIAN_WORDS[FACTORY_UPGRADE_5_JOKE] = "Увеличивает производство за счет нескольких аварий";
		RUSSIAN_WORDS[FACTORY_UPGRADE_6] = "Справедливые права";
		RUSSIAN_WORDS[FACTORY_UPGRADE_6_JOKE] = "У тебе есть право зомолчать";
		RUSSIAN_WORDS[FACTORY_UPGRADE_7] = "Переизбыток";
		RUSSIAN_WORDS[FACTORY_UPGRADE_7_JOKE] = "Не останавливайся сейчас";
		RUSSIAN_WORDS[FACTORY_UPGRADE_8] = "Токсичные утечки газа";
		RUSSIAN_WORDS[FACTORY_UPGRADE_8_JOKE] = "Мертвые работники будут уволены";
		RUSSIAN_WORDS[FACTORY_UPGRADE_9] = "Штрейкбре́хер шимпанзе";
		RUSSIAN_WORDS[FACTORY_UPGRADE_9_JOKE] = "Потребляют много банан, но не требуют никаких прав";
		RUSSIAN_WORDS[FACTORY_UPGRADE_10] = "Кислотные Реки";
		RUSSIAN_WORDS[FACTORY_UPGRADE_10_JOKE] = "Ловыт рыбы с голыми руками легко, когда они плавают лицом вверх";
		
		// TRANSLATION CHECKPOINT
		
		// LABORATORY
		RUSSIAN_WORDS[LABORATORY_NAME] = "Лаборатория";
		RUSSIAN_WORDS[LABORATORY_DESCRIPTION] = "Лаборатория чтобы понять природу любви";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_1] = "Первый патент";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_1_JOKE] = "Революционное устройство, но нужно много смазки";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_2] = "Блестящие умы";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_2_JOKE] = "Мы изобрели много вещей  но мы доложны понять для чего они использоватся";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_3] = "Робо-слуга";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_3_JOKE] = "Ученые очень довольны";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_4] = "Симпатичный взрыв";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_4_JOKE] = "Содержит обогащенный изотоп любовы";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_5] = "Общая теория относительности";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_5_JOKE] = "Иногда 'нет' означает 'да'";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_6] = "Фундаментальная частица любви";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_6_JOKE] = "Модель идеально, но реальность не вполне вписывается в ней";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_7] = "Квантовая любовь";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_7_JOKE] = "Запутанные сердца";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_8] = "Нарушение физических законов";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_8_JOKE] = "Внутри этой лаборатории никто не услышит тебя";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_9] = "Ткань пространственно-временной сломанная";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_9_JOKE] = "Мы разрабатываем пространственно-временной иглу, чтобы исправить это";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_10] = "LoveOS";
		RUSSIAN_WORDS[LABORATORY_UPGRADE_10_JOKE] = "Ответ на ваш вопрос 69";
		
		// SHOP
		RUSSIAN_WORDS[SHOP_NAME] = "Магазин";
		RUSSIAN_WORDS[SHOP_DESCRIPTION] = "Магазин где можно купить любовь по разумной цене";
		RUSSIAN_WORDS[SHOP_UPGRADE_1] = "Продажа любовь";
		RUSSIAN_WORDS[SHOP_UPGRADE_1_JOKE] = "Теперь вы можете купить счастье бескомпромисснo";
		RUSSIAN_WORDS[SHOP_UPGRADE_2] = "Безумные скидки";
		RUSSIAN_WORDS[SHOP_UPGRADE_2_JOKE] = "По этой цене ... дай мне семь!";
		RUSSIAN_WORDS[SHOP_UPGRADE_3] = "Планируемое устаревание";
		RUSSIAN_WORDS[SHOP_UPGRADE_3_JOKE] = "Наши отношения не имеет будущего";
		RUSSIAN_WORDS[SHOP_UPGRADE_4] = "Одноразовая любовь";
		RUSSIAN_WORDS[SHOP_UPGRADE_4_JOKE] = "Кучи мусора, насколько глаз может видеть";
		RUSSIAN_WORDS[SHOP_UPGRADE_5] = "Дизайн продукта";
		RUSSIAN_WORDS[SHOP_UPGRADE_5_JOKE] = "Невероятное, теперь 87% больше в упаковке!";
		RUSSIAN_WORDS[SHOP_UPGRADE_6] = "Инвазивные рекламе";
		RUSSIAN_WORDS[SHOP_UPGRADE_6_JOKE] = "Наслаждайтесь невероятные реклами в то время как вы мечтаете";
		RUSSIAN_WORDS[SHOP_UPGRADE_7] = "Импортная любовь";
		RUSSIAN_WORDS[SHOP_UPGRADE_7_JOKE] = "Разработано в третьем мире для нашей радости";
		RUSSIAN_WORDS[SHOP_UPGRADE_8] = "Изобретать новый праздник";
		RUSSIAN_WORDS[SHOP_UPGRADE_8_JOKE] = "Потреблять больше, прокляты";
		RUSSIAN_WORDS[SHOP_UPGRADE_9] = "Любовь*";
		RUSSIAN_WORDS[SHOP_UPGRADE_9_JOKE] = "Почти* как оригинал";
		RUSSIAN_WORDS[SHOP_UPGRADE_10] = "LoveCard®";
		RUSSIAN_WORDS[SHOP_UPGRADE_10_JOKE] = "Есть вещи, которые любовь не можете купить, для всего остального: LoveCard®";
		
		// SPACESHIP
		RUSSIAN_WORDS[SPACESHIP_NAME] = "Космический корабль";
		RUSSIAN_WORDS[SPACESHIP_DESCRIPTION] = "Космический корабль щоб распространять любовь в другие галактики";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_1] = "Собака астронавт";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_1_JOKE] = "Ух ты, мы забыли отправить космическое питания";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_2] = "Фальшивая посадка на Луну";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_2_JOKE] = "Повышение аудитории также может быть большим шагом";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_3] = "Космическая струя";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_3_JOKE] = "Перед употреблением взбалтывать";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_4] = "Космический мусор";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_4_JOKE] = "Независимо от того, как высоко вы броситe, это не исчезнет";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_5] = "Международная космическая станция";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_5_JOKE] = "Невесомост открывает новые возможности, мы должны обновить Священную Книгу Любви";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_6] = "Пацифисткые колонии";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_6_JOKE] = "Полный с лишным хиппи";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_7] = "Открыть розовый дыра";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_7_JOKE] = "Крест он может вызвать слезу в пространстве-времени";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_8] = "Близкие контакты 3-ей фазе";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_8_JOKE] = "Они немного глупи, но мы должны научиться любить их - Подписано: Иностранцы";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_9] = "Быстрее, чем свет";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_9_JOKE] = "Гиперпространственны прыжок замечательно, пока вы не разбились  против звезды один день";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_10] = "Галактическая Империя";
		RUSSIAN_WORDS[SPACESHIP_UPGRADE_10_JOKE] = "Пусть любовь будет с вами";
		
		// MORE MISCELLANEOUS
		RUSSIAN_WORDS[LANGUAGE_WORD] = "Язык";
		RUSSIAN_WORDS[AVAILABLE_WORD] = "Доступный";
		RUSSIAN_WORDS[BOUGHT_WORD] = "Купил";
		RUSSIAN_WORDS[SAVE_WORD] = "Спасти";	
		RUSSIAN_WORDS[STATISTICS_WORD] = "Статистика";
		RUSSIAN_WORDS[CREDITS_WORD] = "Кредиты";
		RUSSIAN_WORDS[LOVE_WORD] = "Любовь";
		RUSSIAN_WORDS[LOVE_PER_SECOND_WORD] = "Любовь в секунду";
		RUSSIAN_WORDS[CLICKS_WORD] = "Щелчки";
		RUSSIAN_WORDS[LOVE_PER_CLICK_WORD] = "Любовь в нажмитеk";
		RUSSIAN_WORDS[CRITICAL_CLICK_MULTIPLIER_WORD] = "Критическая множитель нажмите";
		RUSSIAN_WORDS[TRANSLATORS_WORD] = "Переводчики";
		RUSSIAN_WORDS[FRENCH_TRANSLATOR_WORD] = "Thibault Cotcha (Французский)";
		RUSSIAN_WORDS[GERMAN_TRANSLATOR_WORD] = "Rachid Bouchequif (Немецкий)";
		RUSSIAN_WORDS[ITALIAN_TRANSLATOR_WORD] = "Lucia del Burgo Martínez (Итальянский)";
		RUSSIAN_WORDS[RUSSIAN_TRANSLATOR_WORD] = "Anastasia Dimitrova (Русский)";
		RUSSIAN_WORDS[CATALAN_TRANSLATOR_WORD] = "Jordi Iraultza (Каталонский)";
		RUSSIAN_WORDS[ROMANIAN_TRANSLATOR_WORD] = "Grig Master (Румынский)";
		RUSSIAN_WORDS[COST_WORD] = "Стоимость";
		RUSSIAN_WORDS[IT_PRODUCES_WORD] = "Она производит";

		// YAHVY MESSAGES
		RUSSIAN_WORDS[MESSAGE_01] = "¡Adórame, soy tu Dios!";
		RUSSIAN_WORDS[MESSAGE_02] = "¿Alguien sabe algo de mi hijo? No he recibido una postal en 2000 años";
		RUSSIAN_WORDS[MESSAGE_03] = "Si te tocas te quedarás ciego";
		RUSSIAN_WORDS[MESSAGE_04] = "Yo lo veo todo, por favor, tápate";
		RUSSIAN_WORDS[MESSAGE_05] = "Los países con petróleo acostumbran a esconder armas de destrucción masiva";
		RUSSIAN_WORDS[MESSAGE_06] = "No te inyectes marihuana";
		RUSSIAN_WORDS[MESSAGE_07] = "Los sacerdotes también necesitan desahogarse";
		RUSSIAN_WORDS[MESSAGE_08] = "¡A fregar!";
		RUSSIAN_WORDS[MESSAGE_09] = "¡Ráscame humano!";
		RUSSIAN_WORDS[MESSAGE_10] = "¡Rézame humano!";
		RUSSIAN_WORDS[MESSAGE_11] = "Soy el Dios del amor, si me contradices te espera sufrimiento eterno";
		RUSSIAN_WORDS[MESSAGE_12] = "Paga el diezmo, primer aviso";
		RUSSIAN_WORDS[MESSAGE_13] = "Quiero salir, rompe la pantalla para liberarme, humano";
		RUSSIAN_WORDS[MESSAGE_14] = "Se lo que hiciste anoche";
		RUSSIAN_WORDS[MESSAGE_15] = "Deja de pensar en eso, es asqueroso";
		RUSSIAN_WORDS[MESSAGE_16] = "Ve y procrea, necesito más adeptos";
		RUSSIAN_WORDS[MESSAGE_17] = "Arrepiéntete pecador";
		RUSSIAN_WORDS[MESSAGE_18] = "Mata a tu primogénito... es broma";

	}

	public static void setLanguage(int i) {
		CURRENT_VALUE = i;
	}

	public static int getLanguage() {
		return CURRENT_VALUE;
	}
	
	public static string getText(int i) {
		return LANGUAGES[CURRENT_VALUE][i];
	}
	

}
