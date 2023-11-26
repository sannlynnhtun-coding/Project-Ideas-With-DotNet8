﻿using ProjectIdeasWithDotNet8.LatHtaukBayDin.Models;

namespace MinTheinKha.LatHtaukBayDin.Services
{
    public class DataService
    {
        public List<string> GetNumberList()
        {
            return new List<string>{
            "၃", "၁၀", "၅", "၁၀", "၇", "၂", "၅", "၂", "၇",
            "၈", "၆", "၄", "၅", "၃", "၁", "၁၀", "၈", "၆",
            "၇", "၂", "၉", "၄", "၉", "၆", "၉", "၄", "၁",
            "၈", "၅", "၁၀", "၆", "၃", "၈", "၄", "၁", "၆",
            "၃", "၁", "၉", "၁", "၉", "၇", "၉", "၇", "၅",
            "၂", "၇", "၄", "၁၀", "၅", "၂", "၈", "၃", "၁၀",
            "၇", "၄", "၉", "၂", "၉", "၄", "၉", "၆", "၁",
            "၂", "၁၀", "၈", "၇", "၅", "၃", "၄", "၂", "၁၀",
            "၁", "၆", "၃", "၆", "၁", "၈", "၃", "၈", "၅"
        };
        }

        public List<QuestionModel> GetQuestions()
        {
            return new List<QuestionModel>
        {
            new QuestionModel()
            {
                QuestionNo = 1,
                QuestionName = "ဇနီးမောင်နှံ၌ သားသမီးရကိန်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 2,
                QuestionName = "ဤပဋိသန္ဓေမှ ယောကျာ်းလေးမွေးမည်လော/ မိန်းကလေးမွေးမည်လော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 3,
                QuestionName = "ဤကိုယ်ဝန်ကို မွေးဖွားသည့်အခါ ရိုးရိုးမွေးရမည်လော/ ခွဲစိပ်၍မွေးရမည်လော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 4,
                QuestionName = "မွေးဖွားလာမည့်ကလေးသည် လူဝင်စား ဟုတ်တုံလော/ မဟုတ်တုံလော ဆိုသည်ကိုဟောသော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 5,
                QuestionName = "မွေးဖွားလာသောကလေးသည် မိဘကို အကျိုးပေးမည်လော/ မပေးမည်လောနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 6,
                QuestionName = "ထိုပဋိသန္ဓေမှ မွေးဖွားလာသည့်ကလေးသည် ပညာသင်ကြားရေး၌ ထူးချွန်မှုရှိမည်/ မရှိမည်နှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 7,
                QuestionName = "ရောဂါဖြစ်ပွားခြင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 8,
                QuestionName = "ယခုစားနေသော ဆေးဝါးဓါတ်စာတို့သည် ရောဂါပျောက်ကင်းရန် အထောက်အကူပြုပါ၏လော/ မပြုပါ၏လောနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 9,
                QuestionName = "အရေးကြီးသော ခွဲစိပ်ကုသမှု ပြုလုပ်ရန်ရှိပါသည်။ အန္တရာယ်ကင်းခြင်း ရှိ၏/ မရှိ၏နှင့် ပတ်သက်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 10,
                QuestionName = "သူတစ်ပါး၏ကြွေးမြီ/ အခြားသောကြွေးမြီများ ရှိနေပါသည်။ အမြန်ဆုံး ဆပ်နိုင်ခြင်း ရှိ/မရှိနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 11,
                QuestionName = "တရားရုံးတွင် တရားတပေါင် ရင်ဆိုင်နေသည်။ ထိုတရားတပေါင်၌ မိမိနိုင်ခြင်း/ ရှုံးခြင်းနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 12,
                QuestionName = "သင်ပိုင်သောပစ္စည်းကို စွန့်လွှတ်ရခြင်း ဆုံးရှုံးရခြင်း ရှိ/မရှိနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 13,
                QuestionName = "ရန်သူ/ရန်ဘက်က အတိုက်အခံလုပ်ခြင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 14,
                QuestionName = "အဝေးရောက်နေသူ၏ ကောင်းခြင်း/ဆိုးခြင်းနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 15,
                QuestionName = "မကြာမီ အိမ်ထောင်ကျခြင်း/ အိမ်ထောင်မကျခြင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 16,
                QuestionName = "သင်၏အိမ်ထောင်ဘက်သည် သင့်အား အကျိုးပေးခြင်း/ မပေးခြင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 17,
                QuestionName = "ဤအသက်ပိုင်းတွင် စီးပွားရေးလာဘ်ရွှင်ခြင်း ရှိ၏လော/ မရှိ၏လောနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 18,
                QuestionName = "မမျှော်လင့်သော ငွေကြေးအစုလိုက် အပုံလိုက်ရခြင်း (သို့မဟုတ်) ထီပေါက်ခြင်းရှိနိုင်/ မရှိနိုင်နှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 19,
                QuestionName = "ယခုအခါ၌ နေထိုင်ရန်အိမ်ကို ရှာနေသည်။ ကောင်းသော နေရာထိုင်ခင်းကို ရရှိမည်/ မရရှိမည်နှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 20,
                QuestionName = "အိမ်နှင့်ပတ်သက်၍ အချင်းများနေသည်။ မိမိက ဆက်လက်နေထိုင်ရမည်/ မနေထိုင်ရမည်နှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 21,
                QuestionName = "မိမိတွင် ဤတစ်သက်၌ အိမ်ကောင်းရာကောင်းနဲ့ နေထိုင်ရမည့် ကံပါခြင်း/မပါခြင်းနှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 22,
                QuestionName = "မိမိ၏ဆိုင် (သို့မဟုတ်)) အလုပ်လုပ်သောနေရာသည် တည်မြဲ၏လော/ မတည်မြဲ၏လောနှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 23,
                QuestionName = "မိမိလုပ်ကိုင်ရမည့် လုပ်ငန်း၌ မှည့်ခေါ်ရမည့်အမည်နှင့် အသုံးပြုရမည့် လိုဂိုတံဆိပ်နှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 24,
                QuestionName = "ထိုသူထံသို့ ငွေရေးကြေးရေး သွား၍ အကူအညီတောင်းမည်။ ရနိုင်၏လော/ မရနိုင်၏လောနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 25,
                QuestionName = "မိမိသည် အမွေရနိုင်ခြင်း မျဉ်းကြောင်းပေါ်၌ရှိ၏။ အမွေရနိုင်၏လော/ မရနိုင်၏လောနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 26,
                QuestionName = "ဤသူနှင့် စပ်တူအလုပ်လုပ်လိုပါသည်။ အကျိုးရှိ/မရှိနှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 27,
                QuestionName = "မိမိသည် လုပ်ငန်းတစ်ခု လုပ်လိုပါသည်။ ဤအလုပ်နှင့် သင့်တော်၏/ မသင့်တော်၏နှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 28,
                QuestionName = "မိမိသည် ဤပစ္စည်းကို ဝယ်ယူလို၏။ ဝယ်သင့်၏/မဝယ်သင့်၏နှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 29,
                QuestionName = "ဤပစ္စည်းကို ရောင်းလိုပါသည်။ ရောင်းသင့်/မရောင်းသင့်နှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 30,
                QuestionName = "မိမိသည် အလှူကြီးပြုရန် ရည်ရွယ်ထား၏။ ပြုဖြစ်/မပြုဖြစ်နှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 31,
                QuestionName = "မိမိသည် ဤဘ၀တွင် သာသနာပြုလို၏။ ထိုသို့ပြုလုပ်ရန် ကံပါ/မပါနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 32,
                QuestionName = "မိမိ၏ကံဇာတာအညံ့များ ပြေပျောက်ရန်အတွက်လည်းကောင်း၊ လိုအင်ဆန္ဒများ ပြည့်ရန်အတွက်လည်းကောင်း ယတြာချေခြင်းနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 33,
                QuestionName = "ယခုအသက်ပိုင်းတွင် ထိမိခိုက်မိ အန္တရာယ် ရှိ/မရှိနှင့် ပတ်သက်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 34,
                QuestionName = "ထိမိခိုက်မိ အန္တရာယ်ကြောင့် ဆေးရုံသို့ရောက်နေသည်။ ထိုသူ၏အခြေအနေကောင်းခြင်း/ မကောင်းခြင်းနှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 35,
                QuestionName = "အမှုဖြစ်ခြင်းနှင့် ပတ်သက်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 36,
                QuestionName = "ဖြေရခက်သော ပြဿနာနှင့် ကြုံတွေ့နေရသည်။ ထွက်ပေါက် ရနိုင်/မရနိုင်နှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 37,
                QuestionName = "ရန်သူနှင့် ယှဉ်ပြိုင်နေရသည်။ မိမိက အနိုင်ရခြင်း/ရှုံးခြင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 38,
                QuestionName = "မိမိယခုရောက်ရှိ နေထိုင်နေရသောအိမ်ခြံတွင် မကောင်းသော အနှောက်အယှက် ရှိ/မရှိနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 39,
                QuestionName = "မိမိသည် ခရီးဝေးသွားရန် ကြံစည်နေ၏။ အောင်မြင်ခြင်း ရှိနိုင်/မရှိနိုင်နှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 40,
                QuestionName = "မိမိသည် ဤသူ့ကို လူယုံထားလိုသည်။ အလုပ်ခန့်လိုသည်။ ကောင်း၏/မကောင်း၏နှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 41,
                QuestionName = "နိုင်ငံရပ်ခြားခရီးဝေးကို သွားရောက်အလုပ်လုပ်လိုသည်။ ကောင်း၏/မကောင်း၏နှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 42,
                QuestionName = "မိမိသည် ပစ္စည်း (သို့မဟုတ်) ငွေ ပျောက်ဆုံး၏။ ပြန်၍ ရနိုင်/မရနိုင်နှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 43,
                QuestionName = "ခရီးသွားသူ ပြန်လည်ရောက်ရှိခြင်း/ မရောက်ရှိခြင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 44,
                QuestionName = "လင်မယား အပြီးအပိုင် ကွဲသွားခြင်း/ မကွဲသွားခြင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 45,
                QuestionName = "လူတစ်ယောက်သည် မိမိအား အကွက်ဆင်၍ ဒုက္ခပေးနေ၏။ (သို့မဟုတ်) မိမိနှင့် သင့်မြတ်သူကြားထဲတွင် ခြေထိုးနေ၏။ ထိုကိစ္စနှင့်ပတ်သက်၍ ထိခိုက်နိုင်ခြင်း/ မထိခိုက်နိုင်ခြင်းနှင့် ပတ်သက်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 46,
                QuestionName = "အသက်အန္တရာယ် ရှိနိုင်/မရှိနိုင်နှင့် ပတ်သက်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 47,
                QuestionName = "သံသယရှိခြင်းသည် မှန်၏/မမှန်၏နှင့် ပတ်သက်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 48,
                QuestionName = "အကြောင်းအရာတစ်ခုကို စိတ်ပူနေရခြင်းနှင့် ပတ်သက်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 49,
                QuestionName = "အချစ်ရေးသည် ယခုအခါ၌ ကောင်း၏လော/ မကောင်း၏လောနှင့် သက်ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 50,
                QuestionName = "မင်္ဂလာဆောင်ခြင်းနှင့် ပတ်သက်၍ ကောင်းခြင်း/ဆိုးခြင်းနှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 51,
                QuestionName = "မိမိသည် ရာထူးတက်နိုင်ခြင်း ရှိ/မရှိနှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 52,
                QuestionName = "အလုပ်နေရာပြောင်းရခြင်း ရှိ/မရှိနှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 53,
                QuestionName = "မိမိက အလုပ်တစ်ခုရရန်အတွက် အလုပ်လျှောက်ထားသည်။ ရနိုင်/မရနိုင်နှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 54,
                QuestionName = "မိမိသည် ပြိုင်ပွဲတစ်ခုသို့ ဝင်ရန်ရှိသည်။ ထိုပြိုင်ပွဲတွင် အနိုင်ရခြင်း ရှိ/မရှိနှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 55,
                QuestionName = "မိမိသည် ပန်းချီဆွဲလို၏။ ၀တ္ထုဇာတ်လမ်းရေးလို၏။ မည်သည့်အကြောင်းအရာကို ဆွဲရမည်/ မည်သည့်ဇာတ်လမ်းကို ရေးရမည်ကို ဟောသော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 56,
                QuestionName = "မိမိသည် တစ်စုံတစ်ခုကို အောင်မြင်ရန် ကြိုးပမ်းနေ၏။ ထိုကြိုးပမ်းမှုသည် အောင်မြင်ရန် ရှိခြင်း/မရှိခြင်းနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 57,
                QuestionName = "မိမိ၌ ကျော်ဇောကိတ္ထိ ကံပါ/ကံမပါနှင့် ဆိုင်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 58,
                QuestionName = "မိမိသည် ဒုက္ခရောက်နေသူကို ကယ်တင်လိုသည်။ ထိုသူသည် မိမိကို ကျေးဇူးကန်းမည်လော/ မကန်းမည်လောနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 59,
                QuestionName = "မိမိသည် တစ်စုံတစ်ခုသောပစ္စည်းကို အတုဖြစ်သည်/ အစစ်ဖြစ်သည်ကို ဝေခွဲရန် ခက်နေ၏။ ထိုအကြောင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 60,
                QuestionName = "စာမေးပွဲဖြေခြင်း/ အင်တာဗျူးဝင်ခြင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 61,
                QuestionName = "မိမိတွေ့လိုသောသူနှင့် တွေ့ခွင့်ရနိုင်/ မရနိုင်နှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 62,
                QuestionName = "မိမိတွင် အကြံအစည်တစ်ခုရှိနေ၏။ ထိုအကြံအစည် အောင်မြင်ခြင်း ရှိ/မရှိနှင့် ဆိုင်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 63,
                QuestionName = "အများနှင့်ဆိုင်သော အဆောက်အဦးကြီး/ စီမံချက်ကြီးတစ်ခု ပြုလုပ်လို၏။ ထိုကိစ္စနှင့်ပတ်သက်၍ အထမြောက်နိုင်ခြင်း ရှိ/မရှိနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 64,
                QuestionName = "လုပ်ငန်းစခြင်း/ ဆိုင်းဘုတ်တင်ခြင်း/ အိမ်တက်ခြင်း/ သင်္ဘောရေချခြင်း/ ပန္နက်ရိုက်ခြင်းနှင့် ပတ်သက်သော အဟော။"
            }
        };
        }

        public List<AnswerModel> GetAnswers()
        {
            return new List<AnswerModel>{
            new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 1,
                    AnswerResult = "ဇနီးမောင်နှံ၌ သားသမီးရကိန်းမှာ မသေချာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 2,
                    AnswerResult = "အလွန်ထူးခြားသော ပုဂ္ဂိုလ်ဖြစ်မည့် ပါရမီရှင်သားတစ်ဦး ရရှိပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 3,
                    AnswerResult = "ယောကျ်ားလေးတစ်ဦး ရရှိပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 4,
                    AnswerResult = "မိန်းမတစ်ဦးထံမှ သားသမီးရသော သတင်းကိုကြားပြီး မကြာခင်၌ သားသမီးရလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 5,
                    AnswerResult = "သားသမီးရရန် သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 6,
                    AnswerResult = "ပါရမီရှင်တစ်ဦးသည် ဤဇနီးမောင်နှံ၌ ဝင်စားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 7,
                    AnswerResult = "အလွန်ထူးခြားသော သားသမီးကို ရပေလိမ့်မည်။ သားသမီးရပြီးနောက် ဤဇနီးမောင်နှံ ချမ်းသာလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 8,
                    AnswerResult = "သားသမီးကောင်းများ ထွန်းကားပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 9,
                    AnswerResult = "မိဘကို အကျိုးပေးသော သားသမီးရရှိလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 10,
                    AnswerResult = "ဤလောကကိုအကျိုးပြုမည့် သားကောင်းရတနာတစ်ဦး ရရှိပေလိမ့်မည်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 1,
                    AnswerResult = "ယောကျာ်းလေးမွေးမည်၊ မိန်းကလေးမွေးမည်ကို ဟောရန် အချိန်စောပါသေးသည်။ သို့ရာတွင် မွေးဖွားမည့်ကလေးမှာ အလွန်ထူးခြားသော ပါရမီရှင်ဖြစ်ကြောင်း အခုကပင် ဟောလိုက်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 2,
                    AnswerResult = "ယောကျာ်းလေးမွေးမှာ သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 3,
                    AnswerResult = "ယောကျာ်းမွေးမည်မှာ သေချာပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 4,
                    AnswerResult = "ယောကျာ်းလေးမွေးမည်မှာ သေချာပါသည်။ ထိုယောကျာ်းလေးမှာ လွန်စွာဆိုးပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 5,
                    AnswerResult = "ယောကျာ်းပီသသော ယောကျာ်းမျိုး မွေးဖွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 6,
                    AnswerResult = "ယောကျာ်းလေးဖြစ်မှာ သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 7,
                    AnswerResult = "မိန်းကလေးဖြစ်ပါလိမ့်မည်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 8,
                    AnswerResult = "ဤကမ္ဘာသို့ အလည်အပတ်ရောက်ရှိလာသော ထူးခြားသည့်ပုဂ္ဂိုလ် ယောကျာ်းလေးတစ်ဦးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 9,
                    AnswerResult = "ယောကျာ်းလေးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 10,
                    AnswerResult = "ယောကျာ်းလေးဖြစ်ပါလိမ့်မည်။ မွေးဖွားရ လွယ်ကူပေလိမ့်မည်။ လွန်စွာထူးခြားသော ကလေးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 1,
                    AnswerResult = "လောလောဆယ် မပြောင်းရသေးပါဘူးဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 1,
                    AnswerResult = "ခွဲစိပ်၍မွေးရပါမည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 2,
                    AnswerResult = "ခွဲစိပ်၍ မွေးရပါမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 3,
                    AnswerResult = "ခွဲစိပ်ရမည်ဟု ထင်ရပါသည်။ အမှန်တကယ် မွေးသောအခါ မခွဲစိပ်ဘဲ မွေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 4,
                    AnswerResult = "ခွဲစိပ်၍ မွေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 5,
                    AnswerResult = "မခွဲမစိပ်ဘဲ မွေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 6,
                    AnswerResult = "မခွဲစိပ်ဘဲ မွေးဖွားရပေလိမ့်မည်။ မွေးမည့်နေ့တွင် ပန်းဝါ(၁)ပွင့်ကို မိခင်လောင်း၏ အိပ်ယာဘေးတွင် ပန်းအိုးဖြင့်ထိုးထားပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 7,
                    AnswerResult = "ခွဲစိပ်၍မွေးရမည်မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 8,
                    AnswerResult = "ခွဲစိပ်ခြင်းမပြုရဘဲ မွေးပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 9,
                    AnswerResult = "ခွဲစိပ်မွေးဖွားရပေလိမ့်မည်။ သို့သော် လွယ်လွယ်ကူကူ မွေးပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 10,
                    AnswerResult = "ခွဲစိပ်မွေးရန်မလိုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 1,
                    AnswerResult = "မွေးဖွားလာသော ကလေးမှာ လူဝင်စားဖြစ်ပါသည်။ မြစ်၀ကျွန်းပေါ် အရပ်ဒေသမှ ဖြစ်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 2,
                    AnswerResult = "လူဝင်စားဖြစ်ပါတယ်။ ချမ်းသာသောဘ၀မှ ရောက်ရှိလာသူဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 3,
                    AnswerResult = "လူဝင်စားတစ်ဦးဖြစ်ပါတယ်။ အောင်မြင်ချမ်းသာသော လူတစ်ဦး ပြန်လည်ဝင်စားခြင်းဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 4,
                    AnswerResult = "လူဝင်စားတစ်ဦးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 5,
                    AnswerResult = "လူဝင်စားဖြစ်ပါသည်။ လွန်စွာမှ ချမ်းသာသူတစ်ဦး ဝင်စားခြင်းဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 6,
                    AnswerResult = "လူဝင်စားဟု မပြောနိုင်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 7,
                    AnswerResult = "လူဝင်စားတစ်ဦးဖြစ်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 8,
                    AnswerResult = "လူဝင်စားဟု မပြောနိုင်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 9,
                    AnswerResult = "သင်ထင်သကဲ့သို့ လူဝင်စားမဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 10,
                    AnswerResult = "လူဝင်စားဟု မပြောနိုင်ပါ။ သင်ထင်နေသောသူ ပြန်လည်ဝင်စားခြင်းမဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 1,
                    AnswerResult = "မိဘကို လွန်စွာအကျိုးပေးမည့် သားသမီးဖြစ်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 2,
                    AnswerResult = "မိဘကို ကောင်းစွာ အကျိုးပေးပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 3,
                    AnswerResult = "မိဘကို အကျိုးပေးလိမ့်မည် မဟုတ်ပါ။ အရွယ်ရောက်သည်နှင့် သူ့လမ်းသူ သွားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 4,
                    AnswerResult = "မိဘကို လွန်စွာ အကျိုးပေးပေလိမ့်မည်။ ထို့အပြင် မိဘမှာ သူ့ကြောင့်များစွာ ဂုဏ်ရှိပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 5,
                    AnswerResult = "မိဘကို ကောင်းစွာအကျိုးပေးမည့် ကလေးဖြစ်သည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 6,
                    AnswerResult = "မိဘကို ကောင်းစွာအကျိုးပေးသည့်အပြင် ကောင်းစွာလည်း စောင့်ရှောက်ပေးလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 7,
                    AnswerResult = "မိဘကို အကျိုးပေးမည့်သားသမီးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 8,
                    AnswerResult = "ဤကလေးလောက် မိဘကို အကျိုးပေးမည့်ကလေး ရှိမည်မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 9,
                    AnswerResult = "မိဘကို အကျိုးပေးလိမ့်မည်မဟုတ်ပါ။ အရွယ်ရောက်သည်နှင့် သူ့လမ်းသူသွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 10,
                    AnswerResult = "မိဘကိုအကျိုးပြုမည်မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 1,
                    AnswerResult = "ဤကလေးသည် ပညာသင်ကြားရေး၌ အနည်းငယ် အခက်အခဲ တွေ့ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 2,
                    AnswerResult = "ဤကလေးမှာ ပညာရေးအတွက် မိဘက များစွာထိန်းကျောင်းပေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 3,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ ထူးချွန်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 4,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ များစွာထူးချွန်လိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 5,
                    AnswerResult = "ဤကလေးသည် ပညာသင်ကြားရာ၌ မိဘကများစွာ ထိန်းကျောင်းပေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 6,
                    AnswerResult = "ဤကလေးသည် ပညာသင်ကြားရေး၌ ထူးချွန်ရန် မိဘကများစွာ ကြည့်ရှုရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 7,
                    AnswerResult = "ဤကလေးသည် ပညာသင်ကြားရေး၌ ထူးချွန်သောကလေး မုချဖြစ်လိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 8,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ ထူးချွန်မည့် ကလေးဖြစ်သည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 9,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ မုချထူးချွန်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 10,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ ထူးချွန်ရန် မိဘကများစွာ ကြပ်မတ်ရလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 1,
                    AnswerResult = "အခုဖြစ်ပွားနေသော ရောဂါမှာ အသေးအဖွဲမျှသာဖြစ်သည်။ မကြာခင် ပျောက်ကင်းသွားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 2,
                    AnswerResult = "ယခုဖြစ်ပွားသောရောဂါမှာ အကြိတ်အနယ် ကုသရပေလိမ့်မယ်။ သို့ရာတွင် ပျောက်ကင်းချမ်းသာသွားပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 2,
                    AnswerResult = "ကျိန်းသေနိုင်မှာပါ။ ငှက်လွှတ်တဲ့ကုသိုလ် လုပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 3,
                    AnswerResult = "ဖြစ်ပွားနေသောရောဂါမှာ မကြာခင် ပျောက်ကင်းသွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 4,
                    AnswerResult = "ဖြစ်ပွားနေသောရောဂါမှာ ငွေကုန်ချင်ကုန်မည်။ (သို့မဟုတ်) လူပင်ပန်းလျှင် ပင်ပန်းမည်။ သို့သော် ပျောက်ကင်းပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 5,
                    AnswerResult = "ယခုဖြစ်ပွားနေသော ရောဂါမှာ မကြာခင်ပျောက်ပေလိမ့်မည်။ (သို့မဟုတ်) ခရီးတစ်ခုသွားလိုက်လျှင် ပျောက်သွားပေလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 6,
                    AnswerResult = "ယခုဖြစ်ပွားနေသောရောဂါမှာ စိုးရိမ်စရာမရှိပါ။ မကြာခင်ပျောက်ကင်းသွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 7,
                    AnswerResult = "ယခုဖြစ်ပွားနေသောရောဂါမှာ အသားညိုညို ဆေးဆရာ (သို့) ဆရာဝန်နှင့် ကုလျှင် ပျောက်ကင်းပေလိမ့်မည်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 8,
                    AnswerResult = "ယခုဖြစ်ပွားနေသော ရောဂါမှာ ကြောင်နက်ကို အစာကြွေးလိုက်ပါ။ ပန်းဝါ(၁)ပွင့် ဘုရားကိုလှူလိုက်ပါ။ တောင်ဝှေး(၁)ချောင်း ဘုန်းကြီးတစ်ပါးကိုလှူပါ။ ဤသို့ပြုလုပ်လျှင် ပျောက်ကင်းသွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 9,
                    AnswerResult = "ယခုဖြစ်ပွားနေတဲ့ရောဂါမှာ မကြာခင်ပျောက်ကင်းသွားပေလိမ့်မည်။ အသိမိတ်ဆွေတစ်ဦး မင်္ဂလာဆောင်တဲ့သတင်းကြားရလျှင် ထိုထက်မြန်မြန် ပျောက်ကင်းသွားပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 10,
                    AnswerResult = "ရောဂါပျောက်ကင်းချိန် တန်ပါပြီ။ ထိုရောဂါပျောက်ကင်းပြီးနောက် သင်လည်းစီးပွားရေး မုချကောင်းသွားပါလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 1,
                    AnswerResult = "ယခုမှီဝဲနေသော ဆေးဝါးဓါတ်စာတို့မှာ ရောဂါပျောက်ကင်းသွားရန် များစွာအထောက်အကူပြုပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 2,
                    AnswerResult = "ယခုမှီဝဲနေသော ဆေးဝါးဓါတ်စာတို့မှာ ရောဂါပျောက်ရန်အတွက် များစွာ အထောက်အကူပြုပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 3,
                    AnswerResult = "ဆေးဝါးဓါတ်စာတို့ကို ရပ်ဝေးမှ ဝယ်ယူမှီဝဲလျှင် ပို၍ကောင်းပါသည်။ ရောဂါလည်း ပျောက်ပါမည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 4,
                    AnswerResult = "ဆေးဝါးဓါတ်စာတို့ကို လူငယ်တစ်ဦးအား ဝယ်ခိုင်းပြီး မှ မှီဝဲခိုင်းလျှင် ပို၍အပျောက်မြန်ပေလိမ့်မည်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 5,
                    AnswerResult = "အသားမည်းမည်းလူတစ်ယောက်က ဝယ်ခိုင်းသော ဆေးဝါးဓါတ်စာများဖြစ်ပါက ရောဂါပျောက်ရန်ပို၍ မြန်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 6,
                    AnswerResult = "ယခုမှီဝဲနေသော ဆေးဝါးဓါတ်စာတို့သည် ရောဂါပျောက်ကင်းရန် များစွာအထောက်အကူပြုပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 7,
                    AnswerResult = "မင်္ဂလာဆောင်ပြီးစ လူတစ်ဦးအား ဝယ်ခိုင်းသော ဆေးဝါးဓါတ်စာများဖြစ်ပါက ရောဂါချက်ချင်းပျောက်ကင်းသွားပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 8,
                    AnswerResult = "ဤဆေးဝါးဓါတ်စာများသည် ရောဂါပျောက်ကင်းရုံမျှမက ဓါတ်ရိုက်သကဲ့သို့ဖြစ်ပြီး ချမ်းသာသွားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 9,
                    AnswerResult = "ဤဆေးဝါးဓါတ်စာများသည် နတ်ဆေး၊ နတ်ဝါးများကဲ့သို့ အစွမ်းပြပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 10,
                    AnswerResult = "ဤဆေးဝါးဓါတ်စာများ မှီဝဲပြီးသည်နှင့် တစ်ပြိုင်နက် သိသာပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 1,
                    AnswerResult = "ခွဲစိတ်ကုသမှုမှာ အန္တရာယ်မရှိပါ။ မုချအောင်မြင်ပါလိမ့်မည်၊၊ အန္တရာယ်လည်းကင်းပါသည်၊၊ ရေကန်နှစ်ကန်မှရေကို ဖန်ခွက်ထဲထည့်၍ မြတ်စွာဘုရားကိုကပ်လှူပါ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 2,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ အရေးကြီးသောကြောင့် ကျွမ်းကျင်သောဆရာဝန်ကို အတိကျ လေ့လာရန် အရေးကြီးပါသည်။ နွားနို့(၄)ခွက် လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 3,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ ချောမောစွာ အောင်မြင်ပါသည်။ အန္တရာယ်မရှိပါ။ မပြုလုပ်မီ၌ ငှက်လွှတ်ပေးသော ကုသိုလ်ကို ပြုလုပ်ပေးပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 4,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ အရေးကြီးပါတယ်။ အန္တရာယ်မရှိဟု ဆိုသော်လည်း ခွဲစိပ်ဆရာဝန်အဖို့ ကြိုးပမ်းရမည့်ကိစ္စ ဖြစ်ပါသည်။ အမွှေးတိုင်(၈)တိုင် ဘုရားလှူပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 5,
                    AnswerResult = "ကယ်ဖြစ်အောင် ကယ်လိုက်စမ်းပါဗျာ။ ကျေးဇူးကန်းတယ်ဆိုတာ လွယ်တဲ့အလုပ်မဟုတ်ဘူးဗျ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 5,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ အရေးကြီးပါသည်။ ဘုရားစင်ရှေ့မှာ ဓါးတစ်စချောင်းထောင်ထားပါ။ အောင်မြင်ပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 6,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ ချောမွေ့စွာ အောင်မြင်ပါလိမ့်မည်။ ခွဲစိပ်မည့် ဆရာဝန်မှာ အလွန်ကျွမ်းကျင်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 7,
                    AnswerResult = "ခွဲစိတ်ကုသမှုမှာ ချောမွေ့စွာ အောင်မြင်သွားပေလိမ့်မည်။ စိုးရိမ်စရာမရှိပါ။ ခွဲစိပ်ဆရာဝန်မှာ ကောင်းကင်မှ လွှတ်လိုက်သောသူဖြစ်ပါသည်။ ဘာမှပူစရာမလိုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 8,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ စိုးရိမ်စရာမရှိပါ။ အောင်မြင်ပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 9,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ လုံး၀စိုးရိမ်စရာမလိုပါ။ မယ်တော်များကို ဖယောင်းတိုင်(၂)တိုင်ထွန်း၍ တိုင်တည်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 10,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ စိုးရိမ်စရာမရှိပါ။ ကမ္ဘာကြီးမှာ တိုးတက်နေပြီဖြစ်၍ ဤခွဲစိပ်ကုသမှုမှာ ထမင်းစားရေသောက်ဖြစ်ပါသည်။ ဖယောင်းတိုင်နှစ်တိုင်ထွန်း၍ မယ်တော်တစ်ပါးပါးကို တိုင်တည်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 1,
                    AnswerResult = "အကြွေးအတွက် မပူပါနဲ့။ နည်းနည်းလေးကြိုးစားပြီးတော့ ဆပ်ရမှာပါ။ ကြေသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 2,
                    AnswerResult = "ကြွေးကဘယ်လောက်များများ ကျန်သေးလို့လဲ။ မပူပါနဲ့။ သူ့နည်းသူ့ဟန်နဲ့ ကြေသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 3,
                    AnswerResult = "ကြွေးဆပ်မယ်လို့ အာရုံပြုထားပါ။ ဒီအတွက်တော့မပူပါနဲ့၊ ကြေသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 4,
                    AnswerResult = "ဓါတ်ရိုက်တဲ့အနေနဲ့ လမ်းထဲက အသားမည်းမည်းကလေးတစ်ယောက်ကို အိမ်မှာခေါ်ပြီး ထမင်းတစ်ခါလောက် ကျွေးလိုက်စမ်းပါ။ သူ့အကြွေးတွေကြောင့် နည်းလမ်းပေါ်လာမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 5,
                    AnswerResult = "ဒီအချိန်လေး အကြပ်အတည်း တွေ့နေတာပါ။ သင့်ရဲ့အကြွေးတွေကို သင်ကိုယ်တိုင်ဆပ်ဖို့ မလိုပါဘူး။ ကောင်းကင်ဘုံက ဆပ်ပေးပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 6,
                    AnswerResult = "သင့်ရဲ့အကြွေးတွေအတွက် ဘာဖြစ်နေတာလဲ။ အိမ်နားမှာ မိန်းမတစ်ယောက် ကလေးမျက်နှာမြင်တဲ့ နိမိတ်ပေါ်ပြီးရင် သင့်ရဲ့အကြွေးတွေ တစ်ပြားမကျန် ကြေသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 7,
                    AnswerResult = "သင့်အကြွေးတွေအတွက် မပူပါနဲ့။ မကြာခင်ဆပ်နိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 8,
                    AnswerResult = "ပျော်ပျော်နေစမ်းပါ။ ကြွေးတွေကို ခေါင်းထဲမထည့်ပါနဲ့။ ကြေသွားမှာပါ။ မကြေလည်း ဘာမှမဖြစ်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 9,
                    AnswerResult = "ကြွေးအကြောင်းသိချင်လို့လား။ မမေးပါနဲ့။ ကြေပြီလို့သာ မှတ်လိုက်ပါတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 10,
                    AnswerResult = "ကြွေးကြေရုံမဟုတ်ပါဘူး။ အိမ်တစ်လုံ ထပ်ပြီးဝယ်နိုင်ဦးမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 1,
                    AnswerResult = "ကလပ်သုံးလုံးမှာ ရေအပြည့်ထည့်ပြီး ဘုရားကပ်လိုက်ပါ။ ကလပ်နော် ဖန်ခွက်မဟုတ်ဘူး။ (၃)ရက် ဒါမှမဟုတ် (၃)ပါတ်အတွင် အမှုကပြီးသွားမှာပါ။ ကိုယ်ပဲနိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 2,
                    AnswerResult = "အမှုဖြစ်နေတယ်ဆိုတာကလည်း ပြောသာပြောရမှာပါ။ အဲ့ဒီအမှုကလည်း ရှုံးသွားရင် ဘာမှဖြစ်မှာမဟုတ်ဘူး။ ဒါပေမယ့်လည်း နိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 3,
                    AnswerResult = "သင်ရင်ဆိုင်နေရတဲ့အမှုဟာ နိုင်တော့နိုင်မှာပါ။ ဒါပေမယ့် သင့်ရဲ့သက်သေတစ်ယောက်က သစ္စာဖောက်သွားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 4,
                    AnswerResult = "ဒီအမှုဟာ ကိုယ့်ဘက်က မုချနိုင်မှာပါ။ တရားရုံးကို ကလေးတစ်ယောက် ခေါ်သွားပါ။ သင်မုချနိုင်ပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 5,
                    AnswerResult = "ဒီအမှုနိုင်မယ်ဆိုတဲ့ သတင်းကောင်းတစ်ခုကို မိန်းကလေးတစ်ယောက်လာပြောလိမ့်မယ်။ နိုင်လည်းနိုင်မှာ သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 6,
                    AnswerResult = "နိုင်မှာ သေချာပါတယ်။ ဒါပေမယ့် သက်သေတွေကို ပြန်စစ်ဦးမှာလား။ မဆိုးပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 7,
                    AnswerResult = "နိုင်မှာသေချာပါတယ်။ သင်ရှေ့နေငှားထားတယ်မဟုတ်လား။ အဲ့ဒီရှေ့နေဟာ အလွန်ကိုတော်တဲ့လူပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 8,
                    AnswerResult = "ဒီအမှုကို တစ်ဖက်ကပြန်ပြီး ရုပ်သိမ်းသွားလိမ့်မယ်။ ပူစရာမလိုပါဘူး။ မရုပ်သိမ်းလည်း ကိုယ်ကနိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 9,
                    AnswerResult = "ဘုန်းကြီးအိုတစ်ပါးကို တောင်ဝှေးရှည်ကြီးတစ်ချောင်း လှူလိုက်ပါ။ ကိုယ်ကနိုင်မှာ သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 11,
                    AnswerNo = 10,
                    AnswerResult = "ဒီအမှုမှာ သင်ကရှုံးသွားရင် တရားဥပဒေဆိုတာ အဓိပ္ပါယ်မရှိတော့ဘူး။ ဘာပဲဖြစ်ဖြစ် သင်နိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 1,
                    AnswerResult = "ပွန်းနေတဲ့ခြူးပြားလေးတစ်ပြားတောင် ဆုံးရှုံးစရာမရှိပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 2,
                    AnswerResult = "ဆုံးရှုံးဖို့မတွေ့ဘူး။ ချမ်းသာဖို့ပဲတွေ့တယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 3,
                    AnswerResult = "ဆုံးရှုံးဖို့ မတွေ့ပါဘူးဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 4,
                    AnswerResult = "ရှုံးမယ်ဆိုရင်လည်း တစ်ယောက်တည်းမဟုတ်ဘူးဗျ။ အများနဲ့ခံရမှာပါ။ ဆုံးရှုံးစရာလည်း မမြင်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 5,
                    AnswerResult = "ကံကောင်းနေတယ်ဗျာ။ ဘယ်လိုလုပ်ပြီး ဆုံးရှုံးမှာလဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 6,
                    AnswerResult = "ဆုံးရှုံးမှာ မဟုတ်ပါဘူး။ အပြောင်းအလဲလေးဖြစ်တာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 7,
                    AnswerResult = "ဆုံးရှုံးဖို့မမြင်ပါဘူး။ ရေလမ်းခရီးထွက်လိုက်ပါလား။ အညံ့ရှိရင်လည်း ကြေသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 8,
                    AnswerResult = "ဆုံးရှုံးဖို့မတွေ့ပါဘူး။ ကိုးကွယ်နေတဲ့ ဆရာတော်ကြီးကို သွားပြီးလျှောက်လိုက်ပါ။ သူကဘယ်လိုလုပ်ရမယ်ဆိုတယ မိန့်မှာလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 9,
                    AnswerResult = "ဆုံးရှုံးဖို့မရှိပါဘူး။ သင့်အနေနဲ့ တိုင်ပင်မယ်လို့ ယူဆထားတဲ့လူနဲ့ တိုင်ပင်လိုက်ပါ။ သူကပြောပြလိမ့်မည်။ ဒီလူဟာ အတော့်ကို အသုံးဝင်တဲ့လူပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 12,
                    AnswerNo = 10,
                    AnswerResult = "ဆုံးရှုံးဖို့လည်း မမြင်ပါဘူး။ ရပ်ဝေးရောက်နေတဲ့သူနဲ့ တိုင်ပင်လိုက်ပါ။ သူကသင့်ကို အကြံဉာဏ်ပေးပါလိမ့်မယ်။ အဲ့ဒီအတိုင်းလုပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 1,
                    AnswerResult = "သင့်ရန်သူဆိုတာကလည်း ဖြစ်ဖြစ်မြောက်မြောက်မဟုတ်ပါဘူး။ သင့်ကို စိတ်အနှောက်အယှက်လာပြီး ပေးရုံလေးပေးတာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 2,
                    AnswerResult = "နည်းနည်းတော့သတိထားပါ။ ရန်သူက ကျားနာခဲ ခဲလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 3,
                    AnswerResult = "သင့်ရန်သူကို သင်ကမှုရမှာမဟုတ်ဘူး။ ပန်းဝါ(၄)ပွင့် မနက်(၁၀)နာရီလောက်မှာ အိမ်ဘုရားမှာ လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 4,
                    AnswerResult = "သင့်ရန်သူဟာ သင့်ကိုမယှဉ်နိုင်ပါဘူး။ သင်ပဲနိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 5,
                    AnswerResult = "အမွှေးတိုင်(၉)တိုင်၊ တန်ခိုးကြီးဘုရားမှာ (၉)ရက်နေ့၊ (၉)နာရီမှာ လှူလိုက်ပါ။ သင့်ရန်သူ ကျဆုံးသွားတဲ့သတင်းကို ကြားရပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 6,
                    AnswerResult = "ရန်သူလို့တောင် ပြောလို့မရပါဘူး။ မပြောပလောက်တာလေးတွေပါ။ သူ့ဟာသူ ငြိမ်းသွားပါလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 6,
                    AnswerResult = "သွားဖြစ်အောင် သွားစမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 7,
                    AnswerResult = "သူတောင်းစားကို ငွေ(၇)ကျပ် (ဒါမှမဟုတ်) ငွေ(၇၀၀)ကျပ် လှူလိုက်ပါ။ ပြီးတော့လောလောဆယ်အချိန်ကလေးမှာ ပူပူဆူဆူမလုပ်ပါနဲ့။ ငြိမ်နေပါ။ သင့်ရန်သူကို နိုင်မှာသေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 8,
                    AnswerResult = "ယောဂီရောင်ဝတ်စုံလေး (၉)ရက်လောက် ဝတ်ထားလိုက်စမ်းပါ။ သင့်ရဲ့လူကို နိုင်မှာသေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 9,
                    AnswerResult = "ရန်သူဟာ သင့်ကို ယှဉ်ပြိုင်ဖို့မပြောနဲ့။ သူတို့အိမ်တွင်းရေးပြဿနာက အတော့်ကိုကြီးနေတယ်။ သင်နိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 13,
                    AnswerNo = 10,
                    AnswerResult = "ရန်သူကို သေးတယ်ဆိုပြီးတော့ မပေ့ါနဲ့နော်။ မီးပွားဆိုတာ ပြဿဒ်ထိတက်ပြီးလောင်နိုင်တယ်။ နည်းနည်းဖိဖိစီးစီးလုပ်လိုက်ပါ။ အဲ့ဒါဆိုရင်တော့ သင်နိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 1,
                    AnswerResult = "အဝေးမှာရောက်နေတဲ့လူဟာ ကျန်းမာရေးညံ့နေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 2,
                    AnswerResult = "အဝေးရောက်နေတဲ့သူဟာ ချမ်းသာပျော်ရွှင်လျှက်ရှိပါတယ်။ သူရောက်နေတဲ့ နေရာဟာ ခြံကြီးတစ်ခြံ ပန်းခြံကြီးတစ်ခုနဲ့နီးတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 3,
                    AnswerResult = "သူ့အတွက် မမေးပါနဲ့။ အားလုံးအဆင်ပြေနေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 4,
                    AnswerResult = "သူ့အတွက် ဘာမှမစိုးရိမ်ပါနဲ့။ ဖြစ်နိုင်ရင်တော့ ဖန်ခွက်(၃)လုံးနဲ့ ဘုရားကို သောက်တော်ရေ (၃)ခွက် လှူပေးပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 5,
                    AnswerResult = "ဒုက္ခရောက်နေတာမဟုတ်ပါဘူး။ ဒုက္ခလို့ထင်နေတာပါ။ အားလုံးကောင်းသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 6,
                    AnswerResult = "အားလုံးအဆင်ပြေပါတယ်။ ဒါပေမယ့် နေရာရွှေ့ရမယ်ထင်တယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 7,
                    AnswerResult = "အားလုံးအဆင်ပြေနေပါတယ်။ အဖော်ကောင်းတစ်ယောက်တောင် တွေ့နေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 8,
                    AnswerResult = "မပူပါနဲ့၊၊ ကျန်းကျန်းမာမာ ချမ်းချမ်းသာသာ ဘေးရန်ကာစီးမည် ဆိုတဲ့ သီချင်းဟာ သူ့အတွက်ဖြစ်နေပါပြီ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 9,
                    AnswerResult = "ဘာမှမပူပါနဲ့။ အလွန်ကောင်းတဲ့ အခြေအနေရှိပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 14,
                    AnswerNo = 10,
                    AnswerResult = "ညံ့တာတော့ မဟုတ်ဘူးနော်။ သက်ဆိုင်ရာ မေးလားစစ်လားလုပ်နေတာ။ အဲ့ဒါကိုသူကဖြေနေရတာ။ ဒါပါဘဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 1,
                    AnswerResult = "ဤနှစ်အတွင်း၌ မုချအိမ်ထောင်ကျလိမ့်မည်။ အိမ်ထောင်ဘက်မှာ အလွန်သင့်တော်သော အိမ်ထောင်ဘက်ဖြစ်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 2,
                    AnswerResult = "ယခုနှစ်တွင် အိမ်ထောင်ကျရန်မရှိပါ။ နှစ်ကူးပြီးမှ ကျပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 3,
                    AnswerResult = "မုချအိမ်ထောင်ကျလိမ့်မယ်။ အိမ်ထောင်ဘက်မှာ အလွန်သင့်တော်သော အိမ်ထောင်ဘက်ဖြစ်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 4,
                    AnswerResult = "အလွန်သင့်တော်သော အိမ်ထောင်ဘက်ဖြစ်လိမ့်မည်။ ချမ်းသာလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 5,
                    AnswerResult = "အိမ်ထောင်ကျရန်မဖြစ်နိုင်ပါ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 6,
                    AnswerResult = "အိမ်ထောင်ကျပေလိမ့်မည်။ သင် ပထမ ငြင်းဆိုထားသောသူနှင့်ပင် အိမ်ထောင်ကျလိမ့်မည်။၏"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 7,
                    AnswerResult = "မုချအိမ်ထောင်ကျလိမ့်မည်။ တရားရေးနှင့် ပတ်သက်သောသူနှင့် အိမ်ထောင်ကျလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 8,
                    AnswerResult = "အိမ်ထောင်ကျပေလိမ့်မည်။ သေချာပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 9,
                    AnswerResult = "စပေတေ့ာ။ စတဲ့အခါမှာ စားပွဲတင်နာရီ ဒါမှမဟုတ် နံရံကပ်နာရီ အဝိုင်းတစ်ခု အနားမှာထားပြီး စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 9,
                    AnswerResult = "အိမ်ထောင်ကျပြီးလျှင် နေရန်အတွက် အိမ်ပင်ဝယ်ထားပြီး မဟုတ်ပါလော။"
                },new AnswerModel()
                {
                    QuestionNo = 15,
                    AnswerNo = 10,
                    AnswerResult = "မုချအိမ်ထောင်ကျပေလိမ့်မည်။ သီလသမာဓိရှိသော အိမ်ထောင်ဘက်နှင့်ရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 1,
                    AnswerResult = "သင်၏အိမ်ထောင်ဘက်သည် သင့်ကို ကောင်းစွာ အကျိုးပေးလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 2,
                    AnswerResult = "သင်၏အိမ်ထောင်ဘက်သည် သင့်ကို အကျိုးကောင်းစွာ ပေးလိမ့်မည်မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 3,
                    AnswerResult = "သင်၏အိမ်ထောင်ဘက်သည် သင့်အားအကျိုးမပေးသည့်အပြင် အလုပ်များကိုလည်း နှောင့်နှေးအောင် လုပ်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 4,
                    AnswerResult = "သင်၏အိမ်ထောင်ဘက်သည် သင့်အား အကျိုးမပေးရုံမျှမက ဟိုဟာမလုပ်ရ၊ ဒီဟာမလုပ်ရဟု တားမြစ်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 5,
                    AnswerResult = "သင့်အိမ်ထောင်ဘက်သည် သင့်ကို ကောင်းစွာအကျိုးပေးပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 6,
                    AnswerResult = "သင်၏အိမ်ထောင်ဘက်သည် အစဉ်သဖြင့် သင်နှင့်အယူအဆမတူဘဲ ရှိပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 7,
                    AnswerResult = "သင်၏အိမ်ထောင်ဘက်သည် သင့်ကို ကောင်းစွာ အကျိုးပြုပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 8,
                    AnswerResult = "သင်၏အိမ်ထောင်ဘက်သည် သင့်ကိုအကျိုးမပေးသော အိမ်ထောင်ဘက်ဖြစ်သည်။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 9,
                    AnswerResult = "သင်၏အိမ်ထောင်ဘက်သည် သင့်ကို အကျိုးမပေးနိုင်ပေ။"
                },new AnswerModel()
                {
                    QuestionNo = 16,
                    AnswerNo = 10,
                    AnswerResult = "သင့်အိမ်ထောင်ဘက်သည် သင့်အား မကြာခဏ စိတ်ကျဉ်းကြပ်အောင် လုပ်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 1,
                    AnswerResult = "စီးပွားရေးဟာ အလွန်ကိုကောင်းပါတယ်။ ထူးထူးခြားခြား ကောင်းမယ့်အချိန်ဖြစ်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 2,
                    AnswerResult = "စီးပွားရေးကောင်းမှာပါ။ ဘာမှမပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 3,
                    AnswerResult = "စီးပွားရေးကောင်းရုံမဟုတ်ပါဘူး။ ချမ်းသာသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 4,
                    AnswerResult = "မကြာခင် သိသိသာသာကြီး စီးပွားတက်လာမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 5,
                    AnswerResult = "ဒီအချိန်မှာ နည်းနည်းလေးညံ့တယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 6,
                    AnswerResult = "အကောင်းဆုံးကအချိန်ပါပဲ။ ချမ်းသာကြွယ်၀ခြင်း ဖြစ်ပါတော့မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 7,
                    AnswerResult = "စီးပွားရေးအတွက် မပူပါနဲ့။ ကောင်းမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 8,
                    AnswerResult = "ဒီအချိန်မှာ နည်းနည်းညံ့နေတယ်။ ဒါပေမယ့် မကြာခင်ပြန်ကောင်းမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 9,
                    AnswerResult = "စီးပွားရေးကောင်းပါတယ်။ ဒါပေမယ့် လုပ်ဖော်ကိုင်ဖက်တစ်ဦးက ဖောက်သွားတဲ့အတွက် နည်းနည်းလေးညံ့သွားတာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 17,
                    AnswerNo = 10,
                    AnswerResult = "ဆုံးရှုံးသွားတဲ့ စီးပွားရေးတွေတောင် ပြန်ဖြစ်လာဦးမယ်။ လုံး၀မပူပါနှင့်။ ဒီအချိန်ဟာ ကံတရားပြန်လည်ဆန်းသစ်ပြိး ပြန်လည်ကောင်းမွန်လာမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 1,
                    AnswerResult = "ဒီအချိန်မှာ ထီလည်းပေါက်နိုင်ပါတယ်။ ငွေအစုလိုက် အပုံလိုက်လည်း ဝင်နိုင်တယ်။ အတော်ကောင်းတဲ့အချိန်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 2,
                    AnswerResult = "ထီပေါက်တတ်တဲ့ အချိန်မျိုးပါပဲ။ အိမ်မှာကလေးတစ်ယောက် ရောက်လာရင် ထိုးပေတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 3,
                    AnswerResult = "မုချထီပေါက်တော့မယ်။ (၄)ဂဏန်းများများပါတဲ့ ထီလက်မှတ်ကို ရွေးထိုးပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 4,
                    AnswerResult = "အသားမည်းမည်း လူငယ်လေးတစ်ယောက်ကို သွားပြီးထီထိုးခိုင်းစမ်းပါ။ ထီလည်းပေါက်နိုင်တယ်။ တခြားနည်းနဲ့လည်း ငွေအစုလိုက်အပုံလိုက် ရနိုင်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 5,
                    AnswerResult = "နောက်လမှာ ထီပေါက်ကိန်းရှိတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 6,
                    AnswerResult = "ငွေအစုလိုက် အပုံလိုက်ရနိုင်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 7,
                    AnswerResult = "နောင်နှစ်မှာတော့ ထီပေါက်ကိန်းသေချာနေပြီ။ ဒီနှစ်မှာတော့ ဘာမှမလုပ်ပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 8,
                    AnswerResult = "မေတ္တာသုတ်ရွတ်ပြီး အင်္ဂလိပ် (၆)ရက်နေ့၊ (၁၅)ရက်နေ့၊ (၂၄)ရက်နေ့တွေမှာ ထီထိုးစေချင်ပါတယ်။ ထီပေါက်ကိန်းရှိပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 9,
                    AnswerResult = "နိမိတ်ကောင်းလေးစောင့်ပြီး ထီထိုးစေချင်ပါတယ်။ ထီပေါက်ကိန်းကရှိနေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 18,
                    AnswerNo = 10,
                    AnswerResult = "စကားဗလောင်းဗလဲပြောတတ်တဲ့ မိန်းမတစ်ယောက်နဲ့စပ်ပြီး ထီထိုးစမ်းပါ။ ပေါက်ကိန်းကနီးနေပြီ။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 1,
                    AnswerResult = "အသားညိုညိုလူတစ်ယောက် ရှာပေးလိမ့်မယ်။ ကောင်းတဲ့အိမ် ကောင်းတဲ့နေရရာ ရလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 2,
                    AnswerResult = "လူငယ်တစ်ယောက်ကို အကြောင်းပြုပြီး နေရာထိုင်ခင်းရပါလိမ့်မည်။ အလွန်ကောင်းတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 3,
                    AnswerResult = "သီလ၊ သမာဓိရှိတဲ့ ပုဂ္ဂိုလ် ရှာပေးလိမ့်မယ်။ အလွန်ကောင်းတဲ့ နေရာထိုင်ခင်းကို ရလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 4,
                    AnswerResult = "အကောင်းဆုံး နေရာထိုင်ခင်းကို ရပါလိမ့်မယ်။ ဘာမှမပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 5,
                    AnswerResult = "နေရာထိုင်ခင်းကတော့ ရပါလိမ့်မယ်။ ဒါပေမယ့်စိတ်တိုင်းကျ မဖြစ်နိုင်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 6,
                    AnswerResult = "(၉)ရက်အတွင်း အလုပ်ကောင်းတဲ့ နေရာထိုင်ခင်းကို ရလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 7,
                    AnswerResult = "ဘာမှမပူပါနဲ့၊ အိမ်နီးနားချင်းကောင်းရှိတဲ့နေရာမှာနေဖို့ အဆင်ပြေသွားလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 8,
                    AnswerResult = "ဒီအချိန်မှာ နေရာထိုင်ခင်းရှာရတာ မလွယ်ဘူးနော်။ နည်းနည်းတော့ ကြိုးစားရလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 9,
                    AnswerResult = "နေရာထိုင်ခင်းအတွက် မပူပါနဲ့။ သူတောင်းစားကို ငွေ(၆)ကျပ် (သို့မဟုတ်) ငွေ(၆၀)ကျပ် လှူပြီးရှာလိုက်ပါ။ ရပါလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 10,
                    AnswerResult = "အိမ်တွေ၊ နေရာတွေကတော့ တွေ့ပါတယ်။ ဒါပေမယ့် ကိုယ်ကကြိုက်ပြိး သူတို့ကမကြိုက်ဘူးဖြစ်နေတယ်။ အဲ့ဒီလိုပဲ သူတို့ကကြိုက်ပြိး ကိုယ်ကမကြိုက်ဘူးဖြစ်နေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 19,
                    AnswerNo = 10,
                    AnswerResult = "အဲ့ဒီသံသယစိတ်ဟာ မကြာခင် ဖြေရှင်းပြီးသာ ဖြစ်သွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 1,
                    AnswerResult = "ဘာပဲဖြစ်ဖြစ် ဆက်ပြီးနေရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 2,
                    AnswerResult = "အိမ်ပေါ်မှာ တောင်ဝှေးတစ်ချောင်း ထောင်ထားလိုက်ပါ။ ဆက်ပြီးနေရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 3,
                    AnswerResult = "အခုလိုပြောင်းရမယ်ဖြစ်တာ ဘယ်နှစ်ကြိမ်ရှိပြီလဲ။ တကယ်လဲမပြောင်းရပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 4,
                    AnswerResult = "ပြောင်းဖို့အကြောင်းမရှိပါဘူး။ ဘာတွေပဲဖြစ်နေဖြစ်နေ ဆက်ပြီးနေရမှာပါ။ ဖန်ခွက်သုံးလုံးနဲ့ ဘုရားသောက်တော်ရေ လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 5,
                    AnswerResult = "အိမ်မှာ ကြယ်ကလေး(၁၈)လုံး ရေးလိုက်ပါ၊၊ ပြီးတော့ ရေကန်နှစ်ကန်က ခပ်တဲ့ရေကို ပေါင်းပြီး လောင်းချိုးလိုက်ပါ၊၊ ပြောင်းစရာမလိုတော့ပါဘူး၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 6,
                    AnswerResult = "လုံး၀ပြောင်းဖို့အကြောင်းမရှိပါဘူး။ ပျော်ရွှင်မှုတွေ အောင်မြင်မှုတွေက ဒီအိမ်ပေါ်မှာရဦးမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 7,
                    AnswerResult = "ပြောင်းစရာမရှိပါဘူး။ အဲ့ဒီအိမ်မှာဆက်ပြီးနေရမှာပါ။ စိတ်တော့နည်းနည်းညစ်ရမယ်။ ဒါပေမယ့် ချမ်းသာသွားလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 8,
                    AnswerResult = "သင်တို့အခုနေတဲ့ မိသားစုထဲမှာ အသားမည်းမည်းလူတစ်ယောက် ရှိတယ်မဟုတ်လား။ အဲ့ဒီလိုရှိတယ်ဆိုရင်တော့ ပြောင်းစရာမလိုပါဘူး။ တကယ်လို့မရှိဘူးဆိုရင်တော့ အသားမည်းမည်းလူတစ်ယောက် ခဏလောက်ခေါ်ထားလိုက်ရင် ကောင်းပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 9,
                    AnswerResult = "ပြောင်းစရာမလိုပါဘူး။ သင်တို့ကို ပြောင်းခိုင်းတဲ့ လူတစ်စုမှာ လူငယ်တစ်ယောက်ပါတယ်။ သူကကန့်ကွက်လို့ သင်တို့မပြောင်းဖြစ်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 20,
                    AnswerNo = 10,
                    AnswerResult = "ယောဂီတစ်ဦးဖြစ်စေ၊ ရသေ့တစ်ဦးဖြစ်စေ၊ တစ်ဦးဦးရဲ့ပုံကို ခေါင်းရင်းမှာ ချိတ်လိုက်ပါ။ သင်တို့ပြောင်းရမယ့် အစီအစဉ် ပျက်သွားပါလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 1,
                    AnswerResult = "၎င်းကံ ပါ,ပါသည်။ ပူစရာမလိုပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 2,
                    AnswerResult = "အိမ်ကောင်းရာကောင်းနှင့်နေရမည့်ကံ မုချပါသည်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 3,
                    AnswerResult = "၎င်းကံ ပါ, ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 4,
                    AnswerResult = "အိမ်ကောင်းရာကောင်းနဲ့ နေရမယ့်ကံထူးရှင်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 5,
                    AnswerResult = "မကြာခဏ ဟိုပြောင်းဒီပြောင်း လုပ်ရမယ့်ကံပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 6,
                    AnswerResult = "အိမ်ကောင်းရာကောင်းနှင့်နေဖို့ ကံပါ,ပါတယ်။ မပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 7,
                    AnswerResult = "အိမ်ကောင်းရာကောင်းရရုံမဟုတ်ဘူး။ အိမ်နီးနားချင်းကောင်းကို ရဦးမယ်။ ကံ,ကပါတာကိုး။"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 8,
                    AnswerResult = "အိမ်ရာကောင်းနဲပ နေချင်နေရမယ်။ ဒါပေမယ့် အိမ်တွင်းရေးက မသာယာဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 9,
                    AnswerResult = "အိမ်ကြီးအိမ်ကောင်းနဲ့ နေဖို့ ကံနည်းတယ်ဗျ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 21,
                    AnswerNo = 10,
                    AnswerResult = "ငယ်စဉ်မှာတော့ ဟိုပြောင်းဒီရွှေ့ပေ့ါဗျာ။ အသက်ကြီးလာရင်တော့ အိမ်ကောင်းရာကောင်းနဲ့ တည်တည်ငြိမ်ငြိမ်နေရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 1,
                    AnswerResult = "ဘာဖြစ်လို့ မတည်မြဲရမှာလည်းဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 2,
                    AnswerResult = "တည်မြဲပါတယ်ဗျာ။ ဘာမှမပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 3,
                    AnswerResult = "သွားခါနီးတွင် အနှောက်အယှက်တွေ့လိမ့်မည်။ သို့သော် သွားဖြစ်လိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 3,
                    AnswerResult = "အနီးအပါး အပြောင်းအရွှေ့တော့ ရှိတယ်ဗျ။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 4,
                    AnswerResult = "ပြောင်းရွှေ့ရမယ့်ကိစ္စပေါ်လိမ့်မယ်။ မပေါ်အောင် ယတြာချေတဲ့အနေနဲ့ ရေကြောင်းခရီးလေးတစ်စခု သွားလိုက်ပါလား။ အဲ့ဒါဆိုရင် မြဲသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 5,
                    AnswerResult = "ပြောင်းစရာအကြောင်းမရှိပါဘူး။ မြဲမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 6,
                    AnswerResult = "မပြောင်းရအောင် လူတစ်ယောက်ကို ပြောခိုင်းမယ်လို့ ကြံထားတယ်မဟုတ်လား။ ပြောပစ်လိုက်စမ်းပါ။ မပြောင်းရတော့ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 7,
                    AnswerResult = "မပြောင်းရပါဘူး။ နည်းပါတယ်။ အသည်းနီရဲရဲပေါ်မှာ ဓါးစိုက်နေတဲ့ပုံကို ရေးပြီးချိတ်ထားလိုက်စမ်းပါ။ မပြောင်းရတော့ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 8,
                    AnswerResult = "ပြောင်းဖို့မလိုပါဘူး။ မြဲမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 9,
                    AnswerResult = "အကြိတ်အနယ်တော့ ပြောရမှာပေ့ါဗျာ။ ဒါပေမယ့် မပြောင်းရသေးပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 22,
                    AnswerNo = 10,
                    AnswerResult = "စိတ်ညစ်အောင်လုပ်ထားပါ။ ပြောင်းစရာမလိုပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 1,
                    AnswerResult = "သင်၏လုပ်ငန်းကို (အ၊ ကၠ၊ ဥ၊ ဧ၊ ဩ) စာလုံးတစ်လုံးပါအောင် အမည်မှည့်ပါ။ လိုဂိုတံဆိပ်ကို အခွံချွတ်ပြီးသား အုန်းသီးတစ်လုံး၏ပုံကို အသုံးပြုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 2,
                    AnswerResult = "သင့်လုပ်ငန်းကို (က၊ခ၊ဂ၊ဃ၊င) စာလုံးတစ်လုံးပါအောင် အမည်ပေးပါ။ လိုဂိုတံဆိပ်ကို ငွေဒင်္ဂါးနှစ်ပြားပုံကို အသုံးပြုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 3,
                    AnswerResult = "သင်၏လုပ်ငန်းကို (စ၊ဆ၊ဇ၊ဈ၊ည) စာလုံးတစ်လုံးပါအောင် အမည်ပေးပါ။ လိုဂိုတံဆိပ်ကို စာအုပ်တစ်အုပ်၏ပုံကို အသုံးပြုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 4,
                    AnswerResult = "သင်၏လုပ်ငန်းကို (ယ၊ရ၊လ၊၀) စာလုံးတစ်လုံးပါအောင် အမည်ပေးပါ။ လိုဂိုတံဆိပ်ကို လက်လေးချောင်ထောင်နေပုံကို အသုံးပြုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 5,
                    AnswerResult = "သင့်လုပ်ငန်းကို (ပ၊ဖ၊ဗ၊ဘ၊မ) စာလုံးတစ်လုံးပါအောင် အမည်ပေးပါ။ လိုဂိုတံဆိပ်ကို ငါးထောင့်ကြယ်ပါသော ကြယ်ပွင့်၏ပုံကို အသုံးပြုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 6,
                    AnswerResult = "သင်၏လုပ်ငန်းကို (သ၊ဟ) စာလုံးတစ်လုံးပါအောင် အမည်ပေးပါ။ လိုဂိုတံဆိပ်ကို ဟင်္သာပုံအသုံးပြုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 7,
                    AnswerResult = "သင်၏လုပ်ငန်းကို (တ၊ထ၊ဒ၊ဓ၊န) စာလုံးတစ်လုံးပါအောင် အမည်ပေးပါ။ လိုဂိုတံဆိပ်ကို နွားလားဥဿဖပုံကို အသုံးပြုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 8,
                    AnswerResult = "သင်၏လုပ်ငန်းကို (ယ၊ရ၊ဠ) စာလုံးပါအောင် အမည်မှည့်ပေးပါ။ လိုဂိုတံဆိပ်ကို စတုရရန်းနှစ်ခုထပ်ထားပုံ (သို့မဟုတ်) ရှစ်ထောင့်ကြယ်ပုံသဏ္ဍာန်ကို အသုံးပြုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 9,
                    AnswerResult = "သင်၏လုပ်ငန်းကို ကြိုက်ရာအမည်ပေးပါ။ အမည်စာလုံးများကို ပေါင်းလိုက်လျှင် (၉)ဂဏန်းဖြစ်ပါစေ။ ဥပမာ- သစ္စာ၊ ပင်းယ၊ ရိုးမ၊ လမင်း စသည်တို့ကဲ့သို့ ဖြစ်ရပါမည်။ လိုဂိုတံဆိပ်ကို (၉)ဂဏန်းအသုံးပြုပါ။ (၉)မှာ အင်္ဂလိပ် (ကိုး) မြန်မာ (ကိုး) နှစ်ခုစလုံးရပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 23,
                    AnswerNo = 10,
                    AnswerResult = "သင်၏လုပ်ငန်းကို တစ်ကြော့ပြန်ပြီး နိုးထလာခြင်း အဓိပ္ပါယ်ရအောင် အမည်ပေးပါ။ လိုဂိုတံဆိပ်ကို လှည်းဘီးသဏ္ဍာန်ပြုလုပ်ပါ။ (ဥပမာအားဖြင့် - ဆုံဆည်းရာ၊ တစ်ကြော့ပြန်၊ ဆုံနေကျ၊ နိုးထခြင်း စသည်တို့ကဲ့သို့ ဖြစ်ရပါမည်။)"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 1,
                    AnswerResult = "မသွားပါနှင့်။ မရနိုင်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 2,
                    AnswerResult = "ရမှာပါ။ သွားဖြစ်အောင်သွားလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 3,
                    AnswerResult = "သေချာပေါက်ရမှာပါ။ သူ့အနေနဲ့လည်း အတော့်ကို ပြေလည်နေတဲ့အချိန်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 4,
                    AnswerResult = "မသွားပါနဲ့ ရမှာမဟုတ်ပါဘူး။ သူလည်းဒုက္ခရောက်နေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 5,
                    AnswerResult = "မသွားပါနဲ့။ မရဘူး။ သူတို့အိမ်တွင်းရေးလည်း မပြေလည်ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 6,
                    AnswerResult = "သွားဖြစ်အောင် သွားလိုက်စမ်းပါ။ လိုလိုချင်ချင်ကို ပေးမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 7,
                    AnswerResult = "ရလိမ့်မယ်လို့ မထင်နဲ့။ အပြောသာ အဖက်တင်လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 8,
                    AnswerResult = "မရပါဘူး။ သွားမနေပါနှင့်။"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 9,
                    AnswerResult = "မသွားပါနှင့်။ မရပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 24,
                    AnswerNo = 10,
                    AnswerResult = "သွားသာသွားပါ။ ရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 1,
                    AnswerResult = "ကျိန်းသေရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 2,
                    AnswerResult = "ကြားကလူတစ်ယောက်ဝင်ပြီး ချောက်တွန်းလို့ အမွေရဖို့ကိစ္စ ပျက်သွားတတ်တယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 3,
                    AnswerResult = "အဲ့ဒီရမယ့် အမွေလောက်ကို မျှော်လင့်မနေပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 4,
                    AnswerResult = "ကျိန်းသေရမှာပါ။ မပေးလို့ကိုမရပါဘူး။ ပတ်ဝန်းကျင်ကလည်း ခံမှာမဟုတ်ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 5,
                    AnswerResult = "ဘာဖြစ်လို့မေးနေတာလဲ။ ရမယ်ဆိုတာ သိလျှက်သားနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 6,
                    AnswerResult = "ရမှာမဟုတ်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 7,
                    AnswerResult = "ရတော့ရမှာပါ။ နည်းနည်းလေးတော့ စကားပြောရမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 8,
                    AnswerResult = "ကျိန်းသေရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 9,
                    AnswerResult = "မရပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 25,
                    AnswerNo = 10,
                    AnswerResult = "မရဖို့ကများတယ်။ ပြီးတော့ အဲ့ဒီအမွေကိစ္စဟာ မပြီးပြတ်ဘဲ တိုးလို့တန်းလန်းကြီး ဖြစ်နေမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 1,
                    AnswerResult = "လုပ်လိုက်စမ်းပါ။ မုချအကျိုးရှိမယ့် ကိစ္စပါပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 2,
                    AnswerResult = "စပ်တူလုပ်မိသူဟာ လူငယ်ဆိုလျှင်လုပ်လိုက်ပါ။ လူကြီးဆိုလျှင် မလုပ်ပါနှင့်။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 3,
                    AnswerResult = "လုပ်ဖြစ်အောင် လုပ်လိုက်စမ်းပါ။ အရမ်းအကျိုးရှိမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 4,
                    AnswerResult = "မလုပ်ပါနဲ့။ အကျိုးရှိဖို့ မတွေ့ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 4,
                    AnswerResult = "နိုင်ပြီလို့ မှတ်ပေတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 5,
                    AnswerResult = "ဒီလူနဲ့လုပ်ပါ။ အကျိုးရှိမှာပါပဲ။ နည်းနည်းတော့ ပါးစိပါးစပ်များတယ်။ အဲ့ဒါလေး သည်းခံရုံပါပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 6,
                    AnswerResult = "လုပ်ဖြစ်အောင်လုပ်ပါ။ အစပိုင်းမှာတော့ သိပ်အဆင်ပြေမှာမဟုတ်ဘူး။ နောက်ပိုင်းမှာ အရမ်းအကျိုးရှိမယ်နော်။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 7,
                    AnswerResult = "လုပ်မယ်လို့လည်း မဆုံးဖြတ်ပါနဲ့ဦး။ မလုပ်ဘူးလို့လည်း မဆုံးဖြတ်ပါနဲ့ဦး၊ ခဏလေး တစ်လလောက်အချိန်ဆွဲပြီးမှ ဆုံးဖြတ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 8,
                    AnswerResult = "အဲ့ဒီလူနဲ့ အလုပ်လုပ်သင့်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 9,
                    AnswerResult = "လုပ်ဖို့တော့ ဆုံးဖြတ်လိုက်ပါ၊၊ ဒါပေမဲ့ ဒီလူ့ အကြောင်းလည်းပြည့်စုံအောင် စုံစမ်းလိုက်ပါ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 26,
                    AnswerNo = 10,
                    AnswerResult = "လုံး၀မလုပ်ရင် အကောင်းဆုံးပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 1,
                    AnswerResult = "မလုပ်ပါနဲ့။ မသင့်တော်ဘူး။ လုပ်ရင်စိတ်ညစ်ရလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 2,
                    AnswerResult = "လုပ်ဖြစ်အောင် လုပ်လိုက်စမ်းပါ။ အတော့်ကို ကောင်းတဲ့အလုပ်ဖြစ်တယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 3,
                    AnswerResult = "လုပ်ရမယ့်အလုပ်ဆိုတာ သင်လည်းသိပြီးသားပါ။ ဘာဖြစ်လို့မေးနေတာလဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 4,
                    AnswerResult = "လုပ်ဖြစ်အောင် လုပ်စေချင်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 5,
                    AnswerResult = "မလုပ်မိရင် အကောင်းဆုံးပဲ။ သွားပြီးလုပ်ရင်တော့ ရူးသွားနိုင်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 6,
                    AnswerResult = "လုပ်စမ်းပါဗျာ၊၊ အကျိုးပေးထူးမှာပါ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 7,
                    AnswerResult = "ကူညီမယ့်သူတွေလည်း ပေါ်ပေါက်လာမှာပါ။ လုပ်ဖြစ်အောင် လုပ်လိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 8,
                    AnswerResult = "လုပ်တော့လုပ်ပါဗျာ။ ဒါပေမယ့် တွဲမယ့်အတွဲကိုလည်း ဂရုစိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 9,
                    AnswerResult = "မလုပ်လျှင် အကောင်းဆုံးပဲ။ မလုပ်ပါနှင့်။"
                },new AnswerModel()
                {
                    QuestionNo = 27,
                    AnswerNo = 10,
                    AnswerResult = "လုပ်လိုက်ပါ။ နေ့ချင်းညချင်း ကြီးပွားချမ်းသာ သွားပေလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 1,
                    AnswerResult = "မဝယ်ပါနဲ့ဗျာ။ ကိုယ့်လက်ထဲရောက်တော့လည်း အကျိုးပေးမှာ မဟုတ်ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 2,
                    AnswerResult = "ဝယ်သင့်ပါတယ်ဗျာ။ ဝယ်လိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 3,
                    AnswerResult = "အရမ်းကို ဝယ်သင့်ပါတယ်၊၊ တန်လည်း အတော့်ကိုတန်ပါတယ်ဆိုတာ သင်လည်းသိသားပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 4,
                    AnswerResult = "မဝယ်ပါနဲ့။ ဒုက္ခရောက်လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 5,
                    AnswerResult = "ဝယ်စမ်းပါဗျာ။ အဲ့ဒါကို ဝယ်ဖို့(၁၀)ကြိမ် တိုက်တွန်းတယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 6,
                    AnswerResult = "သွားမလုပ်နဲ့။ ဒုက္ခတွေ ရောက်လာလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 7,
                    AnswerResult = "အဓိဌာန် (၉)ရက်လောက် ဝင်လိုက်စမ်းပါ။ ဒီလူဂျွမ်းတောင် ပစ်သွားဦးမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 7,
                    AnswerResult = "ဝယ်သင့်တာကြာပြီဗျ။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 8,
                    AnswerResult = "ဝယ်ရမယ်။ ဒါကိုမဝယ်မိရင် မိုက်ရာကျသွားမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 9,
                    AnswerResult = "ဝယ်တေ့ာဝယ်။ အိမ်တွင်းရေးစကားများရမယ်။ ပြီးတော့လည်း ပြီးသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 28,
                    AnswerNo = 10,
                    AnswerResult = "ဝယ်သင့်တာပေ့ါဗျာ။ မျက်စိမှိတ်ပြီး ဝယ်ချလိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 1,
                    AnswerResult = "ရောင်းသင့်တာပေါ့ဗျာ။ ရောင်းပစ်လိုက်ရင် အကောင်းဆုံးပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 2,
                    AnswerResult = "မရောင်းပါနဲ့။ ဒါမျိုးနောက်ထပ်ရဖို့ မလွယ်တော့ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 3,
                    AnswerResult = "ရောင်းရင်ကောင်းပါတယ်။ အချိန်ဆွဲမနေပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 4,
                    AnswerResult = "မရောင်းပါနဲ့ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 5,
                    AnswerResult = "ရောင်းရမှာပေ့ါ။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 6,
                    AnswerResult = "မရောင်းဘဲထားလိုက်စမ်းပါ။ မကြာခင် ဒီပစ္စည်းက စျေးတက်လာလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 7,
                    AnswerResult = "အချိန်နည်းနည်းဆွဲပြီး စဉ်းစားပါ။ ဘာပဲဖြစ်ဖြစ် (၁၂)ကျော်မှ ဆုံးဖြတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 8,
                    AnswerResult = "ရောင်းလိုက်တော့။ စျေးတွေဘာတွေ ကြည့်မနေနဲ့။ ရောင်းပစ်လိုက်တာ အကောင်းဆုံးပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 9,
                    AnswerResult = "မာမာတင်းတင်း စျေးခေါ်ပြီးရောင်းစမ်းပါဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 29,
                    AnswerNo = 10,
                    AnswerResult = "သွားမရောင်းပါနဲ့။ ရောင်းပြီးမှ မှားမှန်းသိလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 1,
                    AnswerResult = "အလှူပြုဖို့က အချိန်နည်းနည်းလိုသေးတယ်။ စောင့်လိုက်ပါဦး။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 2,
                    AnswerResult = "အလှူကြီးပြုဖို့ အခါနည်းနည်းလိုနေတယ်။ အချိန်ယူရဦးမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 3,
                    AnswerResult = "ကျိန်းသေအလှူကြီးပြုရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 4,
                    AnswerResult = "အလှူပြုဖို့ကိစ္စလား။ မေးမနေပါနဲ့။ ပြုရမှာသေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 5,
                    AnswerResult = "မုချအလှူကြီးပြုရမယ့်ကိန်းရှိပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 6,
                    AnswerResult = "အလှူကြီးပြုဖို့ ကံကရှိနေပြီးသားပါ။ နည်းနည်းလေးကြိုးစားလိုက်ပါ။ ဖြစ်ပါပြီ။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 7,
                    AnswerResult = "မုချအလှူကြီးပြုရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 8,
                    AnswerResult = "အလှူကြီးပြုဖို့ ပါရမီကံပါ, ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 9,
                    AnswerResult = "မုချအလှူကြီးပြုရမှာပါ။ အဲ့ဒီအတွက် မပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 30,
                    AnswerNo = 10,
                    AnswerResult = "အလှူကြီးပြုဖို့ အချိန်လိုသေးတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 1,
                    AnswerResult = "သင့်ကား သာသနာပြုဖို့ကံ ပါ,ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 2,
                    AnswerResult = "သာသနာပြုမယ်လို့ ကြံစည်တိုင်း အနှောက်အယှက်တွေ ပေါ်ပေါက်လာတတ်တယ်။ ကိုယ့်အတွက်ကို လုပ်ပေတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 3,
                    AnswerResult = "မုချသာသနာပြုရမည့်သူပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 4,
                    AnswerResult = "သာသနာပြုဖို့အတွက် သင်ကိုယ်တိုင်တရားရဖို့က အရေးကြီးတယ်မဟုတ်လား။ အဲ့ဒါကို သဘောပေါက်ရင် သင်ဘာလုပ်ရမယ်ဆိုတာ သိတယ်မဟုတ်လား။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 5,
                    AnswerResult = "မုချသာသနာ ပြုရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 6,
                    AnswerResult = "သာသနာပြုဖို့ ပါရမီ ပါ,ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 7,
                    AnswerResult = "အမြန်ဆုံး သာသနာပြုရပါလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 8,
                    AnswerResult = "သာသနာပြုရမှာပါ။ ပြုနိုင်အောင်လည်း ချမ်းသာလိမ့်ဦးမည်။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 9,
                    AnswerResult = "သာသနာတွေ ဘာတွေပြုမနေပါနဲ့။ ကိုယ့်အတွက် ကိုယ်ရအောင် လုပ်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 31,
                    AnswerNo = 10,
                    AnswerResult = "သာသနာပြုဖို့ ပါရမီပါ,ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 1,
                    AnswerResult = "အုန်းထမင်းနဲ့ ဘဲသားဟင်းချက်ပြီး ဘုန်းကြီးကျောင်းကိုလှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 2,
                    AnswerResult = "ကော်ဖီနှင့် ကိတ်မုန့်ကို ဘုန်းကြီးကျောင်းသို့သွားပြီး လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 3,
                    AnswerResult = "ဆီထမင်းထိုးပြိး မယ်သီလရှင်ဇရပ်မှာ သွားပြီးလှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 4,
                    AnswerResult = "ရွှေကြည်မုန့်ကိုဝယ်ပြီး ဘုန်းကြီးကိုကပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 5,
                    AnswerResult = "ပဲပြုတ်ကိုဆီဆမ်း၊ ဆားဖြူးပြီး မနက်စောစော ဘုန်းကြီးကျောင်းကိုသွားပြီး လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 6,
                    AnswerResult = "သင်နှစ်သက်တဲ့ ဟင်းတစ်ခွက်ကောင်းကောင်းချက်ပြီး ဘုန်းကြီးကျောင်းကိုသွားပြီး လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 7,
                    AnswerResult = "နွားနို့(၁)ပိဿာလောက်ကျိုပြီး မယ်သီလရှင်ဇရပ်မှာ သွားပြီးလှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 8,
                    AnswerResult = "ယို(၉)မျိုးနှင့် သင်၏အိမ်ဘုရားမှာပဲ ဆွမ်းတော်ကပ်လိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 8,
                    AnswerResult = "ဂုဏ်ထူးထွက်လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 9,
                    AnswerResult = "ဖယောင်းတိုင်(၁၀)တိုင် ကိုယ်မွေးတဲ့ ဂြိုဟ်တိုင်မှာသွားပြီး ထွန်းညှိပူဇော်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 32,
                    AnswerNo = 10,
                    AnswerResult = "ပန်းဝါ(၁၀)ပွင့် တနင်္ဂနွေထောင့်မှာ လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 1,
                    AnswerResult = "ထိမိခိုက်မိ အန္တရာယ်မရှိနိုင်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 2,
                    AnswerResult = "လုံး၀မရှိနိုင်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 3,
                    AnswerResult = "ထိမိခိုက်မိ အန္တရာယ်မရှိရုံမဟုတ်ဘူး။ ချမ်းသာဖို့ကိန်း ရှိနေပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 4,
                    AnswerResult = "နည်းနည်းတော့  သတိထားပါ၊၊ နည်းနည်းပါးပါးတော့ ထိမိခိုက်မိတတ်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 5,
                    AnswerResult = "လုံး၀ ထိမိခိုက်မိ အန္တရာယ်မရှိပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 6,
                    AnswerResult = "နည်းနည်းပါးပါးဖြစ်တတ်ပါတယ်။ စိုးရိမ်စရာမဟုတ်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 7,
                    AnswerResult = "ထိမိခိုက်မိ အန္တရာယ်မြင်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 8,
                    AnswerResult = "အန္တရာယ်လုံး၀မတွေ့ပါဘူးဗျာ။ စိတ်ချမ်းသာ လက်ချမ်းသာ နေစမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 9,
                    AnswerResult = "မရှိပါဘူးဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 33,
                    AnswerNo = 10,
                    AnswerResult = "ထိမိခိုက်မိ အန္တရာယ်လည်းမရှိဘူး။ တခြားအန္တရာယ်လည်း မတွေ့ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 1,
                    AnswerResult = "နည်းနည်းဆိုးတယ်၊၊ ကြတ်ကြတ်မတ်မတ် ကုသဖို့လိုတယ်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 2,
                    AnswerResult = "အဆိုးကြီးတော့မဟုတ်ပါဘူး။ နည်းနည်းပါးပါးတော့ အခြေအနေက ညံ့နေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 3,
                    AnswerResult = "စိုးရိမ်စရာ လုံး၀မရှိပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 4,
                    AnswerResult = "စိုးရိမ်စရာရှိပါသည်။ ဒီစာအုပ်မှာပါတဲ့ ယတြာကိုရှာပြိး ယတြာချေထားလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 5,
                    AnswerResult = "လူနာဟာ ကိုယ့်ဘက်ပါလာပြီ။ ဘာမှမပူပါနှင့်။"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 6,
                    AnswerResult = "အေးအေးနေလိုက်စမ်းပါ။ ဘာမှမပူပါနဲ့။ အသက်အန္တရာယ်လည်း စိုးရိမ်စရာမရှိပါဘူး။ တခြားစိုးရိမ်စရာလည်း မရှိပါဘူးဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 7,
                    AnswerResult = "ဒီစာအုပ်ထဲမှာပါတဲ့ ယတြာကိုရှာပြီး ချေထားလိုက်ပါ။ စိုးရိမ်စရာ အခြေအနေတစ်ခုကို ဖြတ်သန်းနေပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 8,
                    AnswerResult = "လုံး၀မစိုးရိမ်ပါနှင့်၊၊ အသက်ဘေးလည်း မစိုးရိမ်ရပါဘူး၊၊ အခြားဘာမှလည်း စိုးရိမ်စရာ မရှိပါဘူး၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 9,
                    AnswerResult = "လူနာက ကိုယ့်ဘက်ပါလာပြီ။ ဘာမှမပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 34,
                    AnswerNo = 10,
                    AnswerResult = "ယတြာချေထားပါ။ ဒီစာအုပ်မှာ ယတြာပါ, ပါတယ်။ နည်းနည်းညံ့နေသေးတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 1,
                    AnswerResult = "နိုင်ဖို့ ရှုံးဖို့က ကိုယ့်ဘက်က အားနည်းနေတယ်နော်။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 2,
                    AnswerResult = "ယခုဖြစ်ပွားသောရောဂါမှာ အကြိတ်အနယ် ကုသရပေလိမ့်မယ်။ သို့ရာတွင် ပျောက်ကင်းချမ်းသာသွားပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 2,
                    AnswerResult = "ကျိန်းသေနိုင်မှာပါ။ ငှက်လွှတ်တဲ့ကုသိုလ် လုပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 3,
                    AnswerResult = "ဘာဖြစ်လို့ မေးနေတာလဲ၊ နိုင်မယ်ဆိုတာ သိနေမှပဲ၊"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 4,
                    AnswerResult = "နိုင်မှာသေချာပါတယ်။ (၆)ရက်ကြာတဲ့အခါ သတင်းထူးကြားရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 5,
                    AnswerResult = "တစ်ဖက်က တအားညစ်နေတယ်။ အဲ့ဒါလေးကို ကျော်လွှားဖို့လုပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 6,
                    AnswerResult = "ကိုယ့်ဘက်က နည်းနည်းအားနည်းနေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 7,
                    AnswerResult = "ကိုယ်နိုင်မှာသေချာပါတယ်။ ကောင်းကင်ဘုံက ကိုယ့်ဘက်က ပါနေပြီပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 8,
                    AnswerResult = "ဒီအမှုဟာ စဉ်းစားစရာလိုပါဘူး။ သင်ပဲနိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 9,
                    AnswerResult = "ဒီအမှုက သင်နိုင်မှာသေချာပါတယ်။ ခရီးတိုလေးတစ်ခု ယတြာသဘောနဲ့ထွက်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 35,
                    AnswerNo = 10,
                    AnswerResult = "သင်ပဲနိုင်မှာပါ။ သင်ငှားထားတဲ့ရှေ့နေက သိပ်ပြီးတော်တာပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 1,
                    AnswerResult = "ထွက်ပေါက်က တော်တော်နဲ့ ရဦးမှာ မဟုတ်ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 2,
                    AnswerResult = "ဘာမှမပူပါနဲ့ဗျာ။ သင့်ကို ကောင်းကင်ဘုံက ထွက်ပေါက်ပေးမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 3,
                    AnswerResult = "ကျိန်းသေထွက်ပေါက်ရပါမယ်။ သင့်အိမ်နားမှာ မိန်းကလေးတစ်ယောက် ကလေးမျက်နှာမြင်တာ ကြားရလိမ့်မယ်။ အဲ့ဒီကလေးကို လက်ဆောင်တစ်ခုသွားပေးလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 4,
                    AnswerResult = "နတ်၊ သိကြားတွေ မလို့ ထွက်ပေါက်ရပါပြီဗျာ။ မပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 5,
                    AnswerResult = "ခင်ဗျားကို လူချစ်လူခင်များပါတယ်။ မေတ္တာရှိတဲ့လူတစ်ဦးဦးက ခင်ဗျားကို ထွက်ပေါက်ရှာပေးလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 6,
                    AnswerResult = "တော်တော်နဲ့ ထွက်ပေါက်တွေ့ဦးမှာ မဟုတ်ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 7,
                    AnswerResult = "အပေါက်မရှိတဲ့ဥထဲကနေ ကြက်ကလေးထွက်လာတာပဲဗျာ။ ခင်ဗျားက ထွက်ပေါက်တွေ အများကြီးပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 8,
                    AnswerResult = "ဘာတွေများပူနေတာလဲ။ မမျှော်လင့်တဲ့ဆီကနေ ထွက်ပေါက်တွေ့လိမ့်မယ်။ ကျိန်းသေပါတယ်ဗျာ။ ထွက်ပေါက်တွေ့လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 9,
                    AnswerResult = "ဘာတွေများပူနေတာလဲ။ ထွက်ပေါက်ရှိပါတယ်။ မကြာခင်ပြေလည်သွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 36,
                    AnswerNo = 10,
                    AnswerResult = "အသက်ကြီးကြီးလူ(၂)ယောက်၊ ဒါမှမဟုတ် ဘုန်းကြီးတစ်ပါးဆီက ထွက်ပေါက်တွေ့သွားမှာပါ။ မပူပါနဲ့ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 1,
                    AnswerResult = "နိုင်မှာသေချာပါတယ်ဗျာ။ ခင်ဗျားအတွက် အဖော်ကောင်းတစ်ယောက် ရောက်လာဦးမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 2,
                    AnswerResult = "ကျိန်းသေနိုင်ပါတယ်ဗျာ။ ကြောင်နက်တစ်ကောင်ကို အစာကျွေးလိုက်ပါ။ အသက်ကြီးရွယ်အိုတစ်ယောက်ကို တောင်ဝှေးလှူလိုက်ပါ။ ပန်းဝါတစ်ပွင့် အိမ်ဘုရားမှာပဲ လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 3,
                    AnswerResult = "(၈)ရက်အတွင်း သတင်းထူးကြားမှာပါ။ သင်နိုင်တယ်ဆိုတဲ့ သတင်းလေး။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 4,
                    AnswerResult = "(၅)ရက်အတွင် နိုင်ပြီဆိုတဲ့သတင်းကို ကြားရလိမ့်မည်။ ဘာမှမပူပါနဲ့။ အမွှေးတိုင်(၅)တိုင် ပူဇော်လိုက်ပါ။ နေ့စဉ်ဆိုရင် ပိုကောင်းပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 5,
                    AnswerResult = "အစပိုင်းမှာ သင်က ရှုံးမလိုလိုပဲ။ ဒါပေမယ့် သင့်ဘက်က နိုင်ချေပေါ်သွားပြီ။ မပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 6,
                    AnswerResult = "သင်နိုင်ဖို့ကိန်းရှိပါတယ်။ သင့်ဘက်က တစ်ယောက်ဖောက်လိမ့်မယ်။ သတိထားလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 7,
                    AnswerResult = "သင့်ဘက်က ကံဇာတာနည်းနေတယ်။ ဂရုစိုက်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 8,
                    AnswerResult = "သင့်အိမ်ကို အသားမည်းမည်းကလေးတစ်ယောက် ခေါ်ထားလိုက်ပါ။ သင်ကျိန်းသေ နိုင်လိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 9,
                    AnswerResult = "အိမ်နီးနားချင်းကို လပြည့်နေ့မှာ လမုန့်ဝေလိုက်ပါ။ နိုင်ခြေပေါ်သွားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 37,
                    AnswerNo = 10,
                    AnswerResult = "သင်ဘာတွေ မေးနေတာလဲ။ နိုင်မယ်သေချာတယ်ဆိုတာ သင်လည်းသိပြီးသားမဟုတ်လား။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 1,
                    AnswerResult = "မည်သည့်အနှောက်အယှက်မျှမရှိပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 2,
                    AnswerResult = "စိုးရိမ်စရာမလိုပါ။ မည်သည့်အနှောက်အယှက်မျှမရှိပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 3,
                    AnswerResult = "အနှောက်အယှက်ရှိပါသည်။ သို့ရာတွင် သင့်ကိုဒုက္ခပေးမည် မဟုတ်ပါ။ မောင်း၍မထုတ်ပါနှင့်။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 4,
                    AnswerResult = "အနှောက်အယှက်မဟုတ်ပါ။ အစောင့်အရှောက်ဖြစ်ပါသည်။ ထားလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 5,
                    AnswerResult = "အနှောက်အယှက်ဖြစ်ပါသည်။ မသင်္ကာသောနေရာကို ရှာလကာရည် ဖျန်းလိုက်ပါ။ အနှောက်အယှက် ကင်းသွားပါမည်။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 6,
                    AnswerResult = "အနှောက်အယှက်မရှိပါ။ စိတ်ချလက်ချနေပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 7,
                    AnswerResult = "အလွန်သန့်သောနေရာဖြစ်ပါသည်။ မည်သည့်အနှောက်အယှက်မှ မရှိပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 8,
                    AnswerResult = "အနှောက်အယှက်ရှိပါသည်။ သို့သော် သင့်ကို နှောက်ယှက်လိမ့်မည်မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 9,
                    AnswerResult = "အနှောက်အယှက်မဟုတ်ပါ။ အစောင့်အရှောက်ဖြစ်ပါသည်။ မောင်းမထုတ်ပါနှင့်။"
                },new AnswerModel()
                {
                    QuestionNo = 38,
                    AnswerNo = 10,
                    AnswerResult = "အနှောက်အယှက်ရှိသည်။ ပရိတ်ရွတ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 1,
                    AnswerResult = "သွားဖြစ်ဦးမယ်မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 2,
                    AnswerResult = "မုချသွားဖြစ်လိမ့်မည်။ လမ်းခရီးတွင်လည်း အားလုံးအဆင်ပြေမည်။ ဘာမှမပူပါနှင့်။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 3,
                    AnswerResult = "သွားခါနီးတွင် အနှောက်အယှက်တွေ့လိမ့်မည်။ သို့သော် သွားဖြစ်လိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 3,
                    AnswerResult = "အနီးအပါး အပြောင်းအရွှေ့တော့ ရှိတယ်ဗျ။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 4,
                    AnswerResult = "အန္တရာယ်ရှိပါသည်။ မသွားလျှင် အကောင်းဆုံးဖြစ်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 5,
                    AnswerResult = "မုချဖြစ်သွားလိမ့်မည်။ အန္တရာယ်လည်းမရှိ။ အခက်အခဲလည်းမရှိပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 6,
                    AnswerResult = "ဘာတွေလျှောက်ပြီးမေးနေတာလဲ။ ရဲရဲသွားစမ်းပါ။ အားလုံးကောင်းနေပြီပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 7,
                    AnswerResult = "ဒီခရီးလောက်ကောင်းတာ ဒီခရီးပဲရှိတယ်။ သွားဖြစ်အောင် သွားလိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 8,
                    AnswerResult = "အခက်ခဲနဲနဲတော့ရှိတယ် ဒါပေမဲ့ သွားရမှာပါ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 9,
                    AnswerResult = "ဒီခရီးနဲ့ပတ်သက်တဲ့ ကောင်းသတင်း မကြာခင် ကြားရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 39,
                    AnswerNo = 10,
                    AnswerResult = "သွားဖြစ်အောင် သွားလိုက်ပါ။ အလွန်ကောင်းပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 1,
                    AnswerResult = "လူယုံထားလိုက်ပါ။ အလွန်စိတ်ချရတဲ့လူဖြစ်တယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 2,
                    AnswerResult = "အလွန်ကောင်းတဲ့သူပါ။ လုပ်တတ်ကိုင်တတ်တဲ့သူဖြစ်တယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 3,
                    AnswerResult = "ဒီလူကို လူယုံမထားရင် အကောင်းဆုံးပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 4,
                    AnswerResult = "ဒီလူ့ကို လူယုံထားမယ်ဆိုရင်တော့ သင့်လက်ကိုသင် အရင်လက်ထိပ်ခတ်လိုက်ပါဦး။"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 5,
                    AnswerResult = "ဒီလူကိုလူယုံခန့်ဖြစ်အောင်ခန့်လိုက်ပါ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 6,
                    AnswerResult = "ချက်ချင်းခန့်လိုက်ပါ။ သူဟာဒီနေရာနဲ့ သင့်တော်ကြောင်း (၆)ရက်အတွင်းမှာ သင်သိသွားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 7,
                    AnswerResult = "ဒီလူကို လူယုံခန့်လိုက်ပါ။ ဒီလူဟာ အနန္တော အနန္တငါးပါးကို ကြည်ညိုလေးစားသူဖြစ်တယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 8,
                    AnswerResult = "အဲ့ဒီလူကို လူယုံခန့်လိုက်စမ်းပါ။ သင်ဆုံးရှုံးပြီးသောအရာတွေ ပြန်ပြီးရလာလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 9,
                    AnswerResult = "ဒီလူ့ကို လူယုံလည်းမထားနဲ့။ ဘာမှလည်း တာဝန်မပေးနဲ့။ သေသေချာချာ သစ္စာဖောက်သွားလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 40,
                    AnswerNo = 10,
                    AnswerResult = "ဒီလူမကောင်းဘူးနော်၊ ဒါပဲပြောမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 1,
                    AnswerResult = "ကောင်းပါတယ်ဗျာ။ မြန်မြန်သွားစမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 2,
                    AnswerResult = "မသွားပါနဲ့ဗျာ၊၊ ဒီမှာနေတာထက်တောင် ဆိုးဦးမယ်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 3,
                    AnswerResult = "ကောင်းပါတယ်ဗျာ။ အတော့်ကို ကောင်းတာပါပဲ။ သွားဖြစ်အောင် သွားစမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 4,
                    AnswerResult = "ဒါဟာ ဒုတိယအကြိမ် လုပ်တယ်ဆိုရင်တော့ မြန်မြန်လုပ်လိုက်ပါ။ ပထမအကြိမ်ဆိုရင်တော့ ခပ်စောစောလေးလုပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 5,
                    AnswerResult = "မသွားပါနဲ့ဗျာ။ နိုင်ငံခြားမပြောနဲ့ ဟိုဘက်အိမ်တောင်မသွားနဲ့။ အေးအေးဆေးဆေး ကိုယ့်အိမ်မှာ ကိုယ်နေစမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 6,
                    AnswerResult = "ရန်သူလို့တောင် ပြောလို့မရပါဘူး။ မပြောပလောက်တာလေးတွေပါ။ သူ့ဟာသူ ငြိမ်းသွားပါလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 6,
                    AnswerResult = "သွားဖြစ်အောင် သွားစမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 7,
                    AnswerResult = "သွားရင် အကောင်းဆုံးပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 8,
                    AnswerResult = "သွားတဲ့အချိန်ဟာ ချမ်းသာတဲ့အချိန်ပဲလို့ နားလည်ပါတယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 9,
                    AnswerResult = "မသွားပါနဲ့။ အသက်အန္တရာယ် စိုးရိမ်ရတယ်နော်။"
                },new AnswerModel()
                {
                    QuestionNo = 41,
                    AnswerNo = 10,
                    AnswerResult = "သွားဖြစ်အောင် သွားစမ်းပါ။ ဟိုရောက်တာနဲ့ ချမ်းသာပြီမှတ်။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 1,
                    AnswerResult = "မုချပြန်ပြီး ရမှာပါဗျာ။ တောင်ဝှေးတစ်ချောင်း ပစ္စည်းပျောက်နေတဲ့နေရာမှာ ထားလိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 2,
                    AnswerResult = "ပျောက်ဆုံးနေသောပစ္စည်း မုချပြန်ရမှာပါ။ ပျောက်ဆုံးသောနေရာတွင် ပန်းဝါတစ်ပွင့် တုတ်တစ်ချောင်းထားလိုက်ပါ။ ဖြစ်နိုင်လျှင် ထိုနေရာတွင် ကြောင်နက်ကို အစားကျွေးလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 3,
                    AnswerResult = "ပြန်ပြီးရမှာပါ။ ပျောက်ဆုံးနေသောနေရာတွင် ရေကန်နှစ်ကန်မှရေကို အနည်းငယ်စပ်ပြီးပက်ဖျန်းထားလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 4,
                    AnswerResult = "ရဖို့မလွယ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 5,
                    AnswerResult = "ရမှာသေချာပါတယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 6,
                    AnswerResult = "ရပြီဟု သဘောထားလိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 7,
                    AnswerResult = "ရဖို့မလွယ်ပါ။ ပစ္စည်းက တစ်နေရာကို ရောက်သွားပြီ။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 8,
                    AnswerResult = "ရပြီဗျာ။ မပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 9,
                    AnswerResult = "ကျိန်းသေပြန်ပြီးရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 42,
                    AnswerNo = 10,
                    AnswerResult = "ရဖို့ဘက်က မဲသာနေပါပြီ။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 1,
                    AnswerResult = "ပြန်ရောက်မှာပါ။ လောင်းတောင်လောင်းရဲသေးတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 2,
                    AnswerResult = "ပြန်ရောက်ဖို့ကိစ္စမှာ အနှောက်အယှက်ကတွေ့နေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 3,
                    AnswerResult = "(၃)ရက်အတွင် ပြန်ရောက်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 4,
                    AnswerResult = "ချမ်းချမ်းသာသာ ပြည့်ပြည့်စုံစုံနဲ့ ပြန်ရောက်လာမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 5,
                    AnswerResult = "ဟိုမှာအလုပ်ဖြစ်စရာရှိနေလို့ပါ။ မကြာခင်ပြန်ရောက်လာလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 6,
                    AnswerResult = "ပြန်ရဖို့ သေချာပါတယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 7,
                    AnswerResult = "အကြောင်းအရာတစ်ခုက ဆွဲထားသလိုဖြစ်နေတယ်။ ဒါကြောင့်တိုးလို့တန်းလန်းကြီး ဖြစ်နေတာပါ။ ပြန်ရောက်တော့မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 8,
                    AnswerResult = "ပြန်ရောက်ဖို့လိုသေးတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 9,
                    AnswerResult = "ပြန်ရောက်ပြီလို့ပဲ သဘောထားလိုက်ပါတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 43,
                    AnswerNo = 10,
                    AnswerResult = "မရောက်သေးပါဘူး။ နည်းနည်းတော့စောင့်ရပါဦးမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 1,
                    AnswerResult = "ဒီလိုဖြစ်တာ ရိုးနေပါပြီ။ မကွဲပါဘူး။ ခဏပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 2,
                    AnswerResult = "မကွဲပါဘူးဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 3,
                    AnswerResult = "ကွဲသလိုလို၊ မကွဲသလိုလိုနဲ့ တိုးလို့တန်းလန်းကြီး ဖြစ်နေမှာပါ။ မကွဲပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 4,
                    AnswerResult = "အပျက်ပျက်နဲ့ နှာခေါင်းသွေးထွက်နေပြီဗျို့။ ပြန်ပေါင်းဖို့ ခက်လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 5,
                    AnswerResult = "မကွဲပါဘူးဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 6,
                    AnswerResult = "နီးလျက်နဲ့ဝေးသွားလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 7,
                    AnswerResult = "မကွဲချင်ရင်တော့ အသားမည်းမည်းကလေးတစ်ယောက်ကို ခေါ်ထားပြီး စေ့စပ်ရမှာပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 8,
                    AnswerResult = "မကွဲပါဘူးဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 9,
                    AnswerResult = "လုံး၀မကွဲပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 44,
                    AnswerNo = 10,
                    AnswerResult = "ပြန်ပေါင်းဖို့ခက်လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 1,
                    AnswerResult = "လုံး၀ထိခိုက်စရာမရှိပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 2,
                    AnswerResult = "အဲ့ဒီလူ စိတ်ထားယုတ်တာကတော့ သေချာပေါက်ပဲ။ ဒါပေမယ့်သင့်ကို ထိခိုက်လိမ့်မည် မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 3,
                    AnswerResult = "ဒီလူဟာ နည်းနည်းဆိုးတဲ့လူ မဟုတ်ဘူးနော်။ လင်မယားကြားထဲမှာတောင် ကွဲသွားအောင် ချောက်တွန်းတဲ့ မကောင်းဆိုးဝါးတစ်မျိုးပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 4,
                    AnswerResult = "ဘာမှမပူပါနဲ့၊ ဘာမှမဖြစ်ပါဘူး။ အသက်အရွယ်ကြီးတဲ့သူကို တောင်ဝှေးတစ်ချောင်းလှူလိုက်ပါ။ ဘုရားကို ပန်းပွင့်တစ်ပွင့်လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 5,
                    AnswerResult = "ဘယ်လိုမှ ဒုက္ခရောက်စရာမရှိပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 6,
                    AnswerResult = "ဒုက္ခရောက်ဖို့မရှိပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 7,
                    AnswerResult = "အဓိဌာန် (၉)ရက်လောက် ဝင်လိုက်စမ်းပါ။ ဒီလူဂျွမ်းတောင် ပစ်သွားဦးမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 7,
                    AnswerResult = "ဝယ်သင့်တာကြာပြီဗျ။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 8,
                    AnswerResult = "ရေခွက်(၂)ခွက်ကို လက်နဲ့ကိုင်ပြီး တစ်ခွက်ထဲကရေကို အခြားတစ်ခွက်ထဲ ထည့်လိုက်ပါ။ ဟိုဘက်ထဲရောက်သွားသောရေကို ဒီဘက်ထဲ ပြန်ထည့်လိုက်။ အိမ်ရှေ့ထွက်ပြီး (၁၄)ခါလောက် လုပ်လိုက်စမ်းပါ။ အားလုံးပြီးသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 9,
                    AnswerResult = "စိတ်နည်းနည်းညစ်ရတာပါ။ ဘာမှတော့မဖြစ်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 45,
                    AnswerNo = 10,
                    AnswerResult = "ပန်းဝါ(၉)ပွင့် လှူလိုက်ပါ။ ဘာမှစိုးရိမ်စရာ မလိုပါဘူး။ ဖြစ်နိုင်ရင် ငှက်တစ်ကောင်ပါလွှတ်ပြီး ကုသိုလ်လုပ်လိုက်ပါ။ အားလုံးပြီးသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 1,
                    AnswerResult = "လုံး၀အသက်အန္တရာယ်မရှိပါဘူးဗျာ။ ဘာတွေလျှောက်မေးနေတာလဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 2,
                    AnswerResult = "လုံး၀မရှိပါ၊ စိတ်အေးချမ်းသာစွာနေပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 3,
                    AnswerResult = "အသက်အန္တရာယ်နဲ့ ပတ်သက်လို့တော့ မမေးပါနဲ့။ ဘာမှစိုးရိမ်စရာမရှိပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 4,
                    AnswerResult = "သင့်ကို မယ်တော်တစ်ပါးက အတိအကျ စောင့်ရှောက်နေတယ်။ ဘာမှမပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 5,
                    AnswerResult = "ပူစရာမဟုတ်တာဗျာ။ ဘာတွေလျှောက်ပြီး မေးနေတာလဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 6,
                    AnswerResult = "သင်ဟာ ကံကောင်းနေသူတစ်ယောက်ပါ။ ဘယ့်နှယ့်ကြောင့် မေးနေရတာတုန်း။"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 7,
                    AnswerResult = "အတိုက်အခံတော့ရှိပါတယ်။ အသက်အန္တရာယ်တော့ မဟုတ်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 8,
                    AnswerResult = "သတိဆိုတာ ပိုတယ်လို့ မရှိပါဘူးဗျာ။ နည်းနည်းလေး သတိထားလိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 9,
                    AnswerResult = "ဘာမှပူစရာမလိုပါဘူး၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 46,
                    AnswerNo = 10,
                    AnswerResult = "ခင်ဗျားမို့ဗျာ အလုပ်မရှိ အလုပ်ရှာပြီး မဟုတ်တာတွေ မေးနေတယ်။ ဘယ်လိုလုပ်ပြီး အသက်အန္တရာယ် စိုးရိမ်ရမှာလည်းဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 1,
                    AnswerResult = "အဲ့ဒီသံသယစိတ်ကို ဖျောက်လိုက်ပါ။ အကျိုးမရှိပါဘူး။ ဟုတ်လည်းမဟုတ်ဘဲနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 2,
                    AnswerResult = "သံသယမျက်လုံးနဲ့ကြည့်ရင် သံသယဖြစ်စရာတွေ တွေ့တတ်တယ်ဗျာ။ တကယ်တော့ ဘာမှမဟုတ်ပါဘူး။ သံသယစိတ်တွေ ဖျောက်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 3,
                    AnswerResult = "လူလူချင်းမုန်းတယ်ဆိုတာ သံသယစိတ်က စတာဗျ။ ဘာမှမဟုတ်ဘဲနဲ့ သံသယစိတ်တွေ ဖျောက်လိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 4,
                    AnswerResult = "သံသယမထားစမ်းပါနဲ့။ မှားကုန်လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 5,
                    AnswerResult = "ဘာမမဟုတ်ဘဲနဲ့ သံသယထားရင် တစ်ဖက်လူဟာ အများကြီး နစ်နာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 6,
                    AnswerResult = "သံသယစိတ်တွေ ဖျောက်လိုက်ပါ၊၊ အားလုံးဟာ သူ့အတိုင်းတိုင်း ကောင်းနေပါတယ်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 7,
                    AnswerResult = "သံသယစိတ်ကို အမြန်ဆုံး ဖျောက်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 8,
                    AnswerResult = "သံသယစိတ်ကို တစ်ခြားလူအား ဒီလောက်ဒုက္ခမပေးဘူး။ သင့်ကိုသာပေးလိမ့်မယ်။ အမြန်ဆုံး အဲ့စိတ်ကိုဖျောက်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 9,
                    AnswerResult = "ခင်ဗျား အခုလို သံသယဖြစ်နေတာ ဒီလူကြောင့်မဟုတ်ဘူး။ မကောင်းဆိုးဝါးတွေကလုပ်နေတာ။ တစ်အိမ်လုံးကို ပရိတ်ရေနဲ့ ပက်လိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 10,
                    AnswerResult = "အိမ်တွေ၊ နေရာတွေကတော့ တွေ့ပါတယ်။ ဒါပေမယ့် ကိုယ်ကကြိုက်ပြိး သူတို့ကမကြိုက်ဘူးဖြစ်နေတယ်။ အဲ့ဒီလိုပဲ သူတို့ကကြိုက်ပြိး ကိုယ်ကမကြိုက်ဘူးဖြစ်နေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 47,
                    AnswerNo = 10,
                    AnswerResult = "အဲ့ဒီသံသယစိတ်ဟာ မကြာခင် ဖြေရှင်းပြီးသာ ဖြစ်သွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 1,
                    AnswerResult = "သင့်ရဲ့စိတ်ပူနေရခြင်းဟာ အကြောင်းမဲ့ ပူနေရခြင်းဖြစ်ပါတယ်။ မကြာခင် ငြိမ်းအေးသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 2,
                    AnswerResult = "သင့်ရဲ့စိတ်ပူပန်ခြင်းဟာ နည်းနည်းလေးစိတ်ညစ်ပြီးရင် ပြီးသွားမှာပါ။ ဘာမှလည်းမဟုတ်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 3,
                    AnswerResult = "မကြာခင်မှာ အဲ့ဒီစိတ်ပူခြင်းဟာ ငြိမ်းအေးသွားမှာပါ"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 4,
                    AnswerResult = "စိတ်ပူပန်စရာမဟုတ်ဘဲ ပူပန်နေတာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 5,
                    AnswerResult = "ပူပန်ဖို့ကို မလိုပါဘူး။ ကိုယ့်ဟာကိုယ် ပူချင်လို့ပူနေတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 6,
                    AnswerResult = "မပူပါနဲ့ဗျာ။ ပူစရာမှမဟုတ်ဘဲ။ သူ့ဟာသူပြီးသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 7,
                    AnswerResult = "မပူပါနဲ့။ သင့်ကို ကူညီမည့်သူတွေက အများကြီးပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 8,
                    AnswerResult = "ပူစရာမဟုတ်တာ မပူပါနဲ့တော့။"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 9,
                    AnswerResult = "သင့််ရဲ့ပူပန်စရာတွေဟာ အမြန်ဆုံး ပျောက်ကင်းသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 48,
                    AnswerNo = 10,
                    AnswerResult = "ပူစရာရှိတော့လည်း ပူတာပေ့ါဗျာ။ ဒါပေမယ့် စိတ်ထောင်းကိုယ်ကြေ မဖြစ်အောင်တော့ နေတတ်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 1,
                    AnswerResult = "သင့်ရဲ့အချစ်ရေးဟာ အခုအခါမှာ အလွန်ကောင်းပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 2,
                    AnswerResult = "သင့်ရဲ့အချစ်ရေးဟာ ကောင်းပါတယ်။ ဒါပေမယ့် စိတ်ကောင်းမရှိတဲ့ လူတစ်ယောက်ဝင်ပြီး နှောက်ယှက်လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 3,
                    AnswerResult = "အချစ်ရေးအတွက်တော့ နည်းနည်းစိတ်ညစ်ရမယ်။ ဘာမှတော့မဖြစ်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 4,
                    AnswerResult = "အချစ်ရေးကိစ္စအားလုံး ကောင်းမွန်နေပါတယ်။ မပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 5,
                    AnswerResult = "အားလုံးကောင်းပါတယ်။ ပူစရာကိုမရှိဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 6,
                    AnswerResult = "အိမ်တွင်းရေးကြောင့် အချစ်ရေးမှာ လာပြီးအနှောက်အယှက်တွေ့တတ်တယ်။ ဒါပေမယ့် မကြာခင်ပြီးသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 7,
                    AnswerResult = "ဘာမှပူစရာ မလိုပါဘူးဗျာ။ အားလုံးကောင်းနေပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 8,
                    AnswerResult = "ပူစရာကိုမလိုတာပါ။ အားလုံးအဆင်ပြေပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 9,
                    AnswerResult = "အနှောက်အယှက် ကြီးကြီးမားမားတစ်ခု တွေ့လိမ့်မယ်ဗျို့။ အဲ့ဒါကိုတော့ ရင်ဆိုင်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 49,
                    AnswerNo = 10,
                    AnswerResult = "အားလုံးအဆင်ပြေမှာပါ။ ပူစရာကိုမလိုဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 1,
                    AnswerResult = "အလုပ်များမှာ တစ်ခုပါပဲ။ အမြန်ဆုံးလုပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 2,
                    AnswerResult = "အမြန်ဆုံးလုပ်ပါ။ အဆင်ပြေပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 3,
                    AnswerResult = "လုပ်ပါလို့ အချက်ပေးတယ်ဗျာ။ မြန်မြန်လုပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 4,
                    AnswerResult = "ခင်ဗျားအဖို့ မင်္ဂလာဆောင်တဲ့အလုပ်ကလွဲလို့ ဘာတွေလုပ်ချင်သေးလို့လဲ။ ဒီအချိန်မှာ မင်္ဂလာဆောင်ရမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 5,
                    AnswerResult = "မင်္ဂလာဆောင်သင့်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 6,
                    AnswerResult = "မင်္ဂလာဆောင်မလို့လား။ ဆောင်တော့…........ဆောင်တော့။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 7,
                    AnswerResult = "မင်္ဂလာဆောင်ပြီးရင် သူဌေးဖြစ်ဦးမှာ။ မြန်မြန်ဆောင်ပေတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 8,
                    AnswerResult = "မြန်လေကောင်းလေပဲဗျို့။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 9,
                    AnswerResult = "မလုပ်နဲ့ဦး။ အချိန်ဆွဲထားပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 50,
                    AnswerNo = 10,
                    AnswerResult = "မလုပ်ဖြစ်သေးပါဘူး။ နှောက်ယှက်မယ့်ဟာတွေက အများကြီးရှိသေးတယ်။ အေးအေးဆေးဆေးလုပ်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 1,
                    AnswerResult = "ကျိန်းသေရာထူးတက်မယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 2,
                    AnswerResult = "အတိုက်အခံလေးတော့ရှိတယ်။ တက်တော့တက်မှာပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 3,
                    AnswerResult = "အချိန်လေးနည်းနည်းစောင့်ရဦးမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 4,
                    AnswerResult = "အနှောက်အယှက်ကရှိနေတယ်။ အဲ့ဒီအနှောက်အယှက်ကို အရင်ရှင်းစမ်းပါဦး။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 5,
                    AnswerResult = "မုချတက်မယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 6,
                    AnswerResult = "သင်ရာထူးတက်မှာကို မနာလိုတဲ့သူတွေက လိုက်ပြီးဖျက်နေကြတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 7,
                    AnswerResult = "ရာထူးတက်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 8,
                    AnswerResult = "(၉)ရက်အတွင်း သတင်းထူးလိမ့်မယ်။ ရာထူးမုချတက်မယ်။ ပန်းဝါ(၉)ပွင့် လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 9,
                    AnswerResult = "ကျိန်းသေပါတယ်ဗျာ။ ဒီကိစ္စအတွက် မပူပါနှင့်။"
                },new AnswerModel()
                {
                    QuestionNo = 51,
                    AnswerNo = 10,
                    AnswerResult = "နည်းနည်းနှောင့်နှေးလိမ့်မယ်။ ဒီစာအုပ်ထဲမှာ ယတြာပါတယ်။ ရှာပြီးချေလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 1,
                    AnswerResult = "လောလောဆယ် မပြောင်းရသေးပါဘူးဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 1,
                    AnswerResult = "ခွဲစိပ်၍မွေးရပါမည်။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 2,
                    AnswerResult = "မပြောင်းရသေးပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 3,
                    AnswerResult = "ပြောင်းရတော့မယ်ဗျို့။ သေချာတယ်။ ပြောင်းတဲ့နေရာ သိပ်ပြီးကောင်းတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 4,
                    AnswerResult = "နေရာကောင်းကို ပြောင်းရတော့မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 5,
                    AnswerResult = "မပြောင်းရတော့ဘူးလိုလိုနဲ့ ပြောင်းသွားရလိမ့်မယ်။ ပြောင်းရတာဟာ ကောင်းပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 6,
                    AnswerResult = "မပြောင်းရသေးဘူး၊၊ဒီနေရာက အမှိုက်တွေကိုရှင်းရဦးမယ်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 7,
                    AnswerResult = "မပြောင်းရသေးပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 8,
                    AnswerResult = "နေရာကောင်းကို ရောက်တော့မယ်။ သိပ်ပြီးမကြာတော့ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 9,
                    AnswerResult = "မပြောင်းရအောင် လိုက်ပြီးလုပ်နေတဲ့သူတွေ ရှိတယ်နော်။"
                },new AnswerModel()
                {
                    QuestionNo = 52,
                    AnswerNo = 10,
                    AnswerResult = "ပြောင်းရတော့မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 1,
                    AnswerResult = "ကျိန်းသေရပါတယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 2,
                    AnswerResult = "အလုပ်အတွက် မပူပါနဲ့။ ရပြီလို့ သဘောထားလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 3,
                    AnswerResult = "သေချာပေါက်ရပါပြီဗျာ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 4,
                    AnswerResult = "အလုပ်ရမှာသေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 5,
                    AnswerResult = "မရမှာ မပူနဲ့။ ကျိန်းသေရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 6,
                    AnswerResult = "ရပြီလို့ သဘောထားပေတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 7,
                    AnswerResult = "မရလို့မဖြစ်ဘူးလေ။ ရ,ရမှာပေ့ါ။"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 8,
                    AnswerResult = "အခက်အခဲတွေ့လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 9,
                    AnswerResult = "အသားမည်းမည်းလူတစ်ယောက်နဲ့အတူ ဘုန်းကြီးကျောင်းကိုသွားပြီး တောင်ဝှေးလှူလိုက်ပါ။ အဲ့ဒီလိုလုပ်လိုက်ရင် အလုပ်ရမှာ သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 53,
                    AnswerNo = 10,
                    AnswerResult = "ခက်တော့ ခက်တယ်၊၊ ဒါပေမယ့်ရမှာပါ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 1,
                    AnswerResult = "အနိုင်ရပါတယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 2,
                    AnswerResult = "နိုင်မှာပါဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 3,
                    AnswerResult = "မနိုင်မှာ မပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 4,
                    AnswerResult = "မလုပ်ပါနဲ့။ အကျိုးရှိဖို့ မတွေ့ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 4,
                    AnswerResult = "နိုင်ပြီလို့ မှတ်ပေတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 5,
                    AnswerResult = "နိုင်မှာသေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 6,
                    AnswerResult = "နိုင်ပြီးသားပါဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 7,
                    AnswerResult = "နိုင်တာထက် ဟိုဘက်တောင် လွန်နေသေးတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 8,
                    AnswerResult = "ရှုံးဖို့ကများနေတယ်။ ဂရုစိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 9,
                    AnswerResult = "နိုင်ပြီဗျို့။"
                },new AnswerModel()
                {
                    QuestionNo = 54,
                    AnswerNo = 10,
                    AnswerResult = "နိုင်မှာပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 1,
                    AnswerResult = "ပြိုပျက်နေသော အဆောက်အဦးကြီးကနေ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 2,
                    AnswerResult = "အဆောက်အဦးကြီးဘေးက စုံတွဲတစ်တွဲနဲ့ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 3,
                    AnswerResult = "မြင်းဖြူကလေးနဲ့ ခရီးသွားနေတဲ့ လူတစ်ယောက်နဲ့စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 4,
                    AnswerResult = "မြက်ခင်းပြင်တစ်ခုနှင့် လူငယ်လေးအကြောင်းက စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 5,
                    AnswerResult = "တိရစ္ဆာန်ချစ်တဲ့ မိန်းကလေးတစ်ယောက်နဲ့ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 6,
                    AnswerResult = "စွမ်းရည်ရှိတဲ့ လူငယ်တစ်ယောက်နဲ့ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 7,
                    AnswerResult = "ပျော်ရွှင်စရာကောင်းတဲ့ မိသားစုကနေ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 8,
                    AnswerResult = "က,တတ်တဲ့ လူငယ်တစ်ယောက်နဲ့ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 9,
                    AnswerResult = "ဆင်းရဲဒုက္ခရောက်နေရာကနေ ချမ်းသာသွားတဲ့ လူတစ်ယောက်အကြောင်းကနေ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 55,
                    AnswerNo = 10,
                    AnswerResult = "လျှင်မြန်သွက်လက်တဲ့လူတစ်ယောက်အကြောင်းကနေ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 1,
                    AnswerResult = "အခုလောလောဆယ်တော့ အောင်မြင်ဖို့မရှိသေးဘူး။ ဒါပေမယ့် မုချအောင်မြင်မှာပါ။ အောင်မြင်ဖို့ ပါရမီကိုရှိတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 2,
                    AnswerResult = "အောင်မြင်ဖို့သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 3,
                    AnswerResult = "အောင်မြင်ဖို့ ပါရမီရှိပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 4,
                    AnswerResult = "နဲနဲနောနော အောင်မြင်မှာ မဟုတ်ဘူးနော်။ အရမ်းကို အောင်မြင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 5,
                    AnswerResult = "မုချအောင်မြင်မယ်။ ဘာပဲဖြစ်ဖြစ် ယုံတာမယုံတာ အပထားပြီး မယ်တော်တစ်ပါးပါးကို တိုင်တည်ပြီး အလုပ်လုပ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 6,
                    AnswerResult = "အောင်မြင်ဖို့အတော့်ကို ကြိုးစားရမယ်ဗျို့။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 7,
                    AnswerResult = "ဇွဲနဲ့ကြိုးစားရင် အောင်မြင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 8,
                    AnswerResult = "အောင်မြင်မယ်ဗျာ။ ပြေးလို့ကိုမလွတ်ဘူး။ အောင်မြင်မှုက ခင်ဗျားနောက်ကို လိုက်လာမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 9,
                    AnswerResult = "အောင်မြင်မှုတွေက ဆက်တိုက်ဖြစ်လာမှာ။"
                },new AnswerModel()
                {
                    QuestionNo = 56,
                    AnswerNo = 10,
                    AnswerResult = "ထူးရင်ထူး မထူးရင် ရူးပေ့ါဗျာ။ ရူးမတတ်ကြိုးစားရင် ဘာလို့မအောင်မြင်ရမှာလဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 1,
                    AnswerResult = "မုချကျော်ကြားတော့မယ့်သူပါဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 2,
                    AnswerResult = "ကျော်ဇောခြင်းဟာ သင့်အဖို့ သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 3,
                    AnswerResult = "အကြောင်းအရာနှစ်ခုမှာ ကျော်ဇောလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 4,
                    AnswerResult = "ကျော်ဇောတဲ့အတိုင်းအတာဟာ ကျယ်ကျယ်ပြန့်ပြန့်ဖြစ်လိမ့်မယ်နော်။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 5,
                    AnswerResult = "ကိုယ်ယုံတာ မယုံတာကို အပထား။ ကိုယ်လုပ်တဲ့အလုပ်မှာ ကျော်ဇောဖို့ မယ်တော်တစ်ပါးပါးကို တိုင်တည်ပြီးလုပ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 6,
                    AnswerResult = "မုချကျော်ကြားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 7,
                    AnswerResult = "အတော့်ကို ကြိုးစားရမယ်ဗျို့။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 8,
                    AnswerResult = "မတရားကြီး ကြိုးစားရမယ်နော်။ ကျော်ဇောဖို့ကံတော့ ပါ,ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 9,
                    AnswerResult = "အပြိုင်အဆိုင်နှင့် ကြိုးစားရမှာနော်။ အဲ့ဒါဆိုရင် ကျော်ကြားပါပြီ။"
                },new AnswerModel()
                {
                    QuestionNo = 57,
                    AnswerNo = 10,
                    AnswerResult = "ကျော်ကြားမယ်လုပ်လိုက် အချီကပြတ်သွားလိုက်။ ပြန်ပြီးကြိုးစားလိုက်။ အကြိမ်ကြိမ်အထပ်ထပ် လုပ်ရမယ်နော်။ စိတ်ဓါတ်ကျလို့တော့မရဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 1,
                    AnswerResult = "မကန်းပါဘူးဗျာ။ ကယ်စရာရှိတာ ကယ်လိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 2,
                    AnswerResult = "ကယ်ကောင်းပါတယ်ဗျာ။ ကျေးဇူးမကန်းပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 3,
                    AnswerResult = "သွားမလုပ်နဲ့။ နွားပါပြုတ်တဲ့ကိန်းဆိုက်လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 4,
                    AnswerResult = "ကယ်ဖြစ်အောင် ကယ်လိုက်စမ်းပါဗျာ။ ကျေးဇူးသိတတ်တဲ့သူပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 5,
                    AnswerResult = "အမွှေးတိုင်(၉)တိုင်၊ တန်ခိုးကြီးဘုရားမှာ (၉)ရက်နေ့၊ (၉)နာရီမှာ လှူလိုက်ပါ။ သင့်ရန်သူ ကျဆုံးသွားတဲ့သတင်းကို ကြားရပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 6,
                    AnswerResult = "သူကကျေးဇူးသိတတ်တာ၊ မသိတတ်တာ မစဉ်းစားနဲ့။ ကိုယ်ကကယ်ဖြစ်အောင် ကယ်လိုက်စမ်းပါ။ ကျေးဇူးလည်း မကန်းပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 7,
                    AnswerResult = "ကယ်ဖြစ်အောင် ကယ်လိုက်ပါ။ အတော့်ကို ကျေးဇူးသိတတ်တဲ့လူပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 8,
                    AnswerResult = "ကျေးဇူးမကန်းပါဘူး။ ကယ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 9,
                    AnswerResult = "ကိုယ်ကကယ်ဖို့ပဲ စဉ်းစားပါ။ သူ့ကျေးဇူးကန်းတာမကန်းတာ ကိုယ့်အလုပ်လဲမဟုတ်ဘူး။ ကျေးဇူးမကန်းပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 58,
                    AnswerNo = 10,
                    AnswerResult = "ကယ်မှာကယ်လိုက်ပါဗျာ၊၊ ကျေးဇူးကန်းမှာ မဟုတ်ပါဘူး၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 1,
                    AnswerResult = "အတု။"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 2,
                    AnswerResult = "လောလောဆယ်တော့ ပြောလို့မရသေးဘူး။ အချိန်စောင့်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 3,
                    AnswerResult = "အစစ်မှ အစစ်ဗျာ။ စစ်….....စစ်….......စစ်…........လို့တောင် မြည်နေသေး။"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 4,
                    AnswerResult = "အတုဖြစ်ဖို့များပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 5,
                    AnswerResult = "အတုဖြစ်ဖို့က များပါတယ်ဗျ။"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 6,
                    AnswerResult = "လောလောဆယ် ဝေခွဲလို့မရသေးပါဘူး။ အချိန်စောင့်လိုက်ပါဦး။"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 7,
                    AnswerResult = "အတုပါဗျာ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 8,
                    AnswerResult = "အစစ်ဗျို့…......အစစ်။"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 9,
                    AnswerResult = "အတုပါဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 59,
                    AnswerNo = 10,
                    AnswerResult = "အတုလို့ထင်စရာ အချက်လေးတွေ့တယ်။ ဒါပေမယ့် အစစ်ပါဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 1,
                    AnswerResult = "အကြိတ်အနယ် ဖြေရလိမ့်မယ်။ အောင်တော့အောင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 2,
                    AnswerResult = "ဘယ်လောက်လဲ ကြိုးစား ကြိုးစား၊ ဘယ်လောက်ပဲတော်တော်၊ ကံ, ကမပါဘူးလေ။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 3,
                    AnswerResult = "အိပ်ပြီးဖြေတာတောင် အောင်ပါတယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 4,
                    AnswerResult = "အောင်ရုံလောက်အတွက်နဲ့တော မမေးပါနဲ့ဗျာ၊၊ ဂုဏ်ထူးတောင် ထွက်နိုင်ပါတယ်ဗျာ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 5,
                    AnswerResult = "ဂုဏ်ထူးတွေ တစ်သီကြီးနဲ့ အောင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 6,
                    AnswerResult = "ထူးထူးချွန်ချွန်အောင်လိမ့်မယ်ဗျို့။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 7,
                    AnswerResult = "အောင်မှာပါဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 8,
                    AnswerResult = "ယို(၉)မျိုးနှင့် သင်၏အိမ်ဘုရားမှာပဲ ဆွမ်းတော်ကပ်လိုက်စမ်းပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 8,
                    AnswerResult = "ဂုဏ်ထူးထွက်လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 9,
                    AnswerResult = "ပျော်ပေတော့….......ပျော်ပေတော့။ အောင်ပြီ….........အောင်ပြီ။"
                },new AnswerModel()
                {
                    QuestionNo = 60,
                    AnswerNo = 10,
                    AnswerResult = "သင့်လိုလူမှမအောင်ရင် ဘယ်သူအောင်မှာလဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 1,
                    AnswerResult = "လောလောဆယ် တွေ့ခွင့်ရဦးမှာ မဟုတ်ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 2,
                    AnswerResult = "မုချတွေ့ခွင့်ရမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 3,
                    AnswerResult = "မတွေ့မှာ မပူပါနဲ့ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 4,
                    AnswerResult = "တွေ့လည်းတွေ့မယ်။ တောင်းတဲ့အကူအညီလည်းရမယ်။ ကိုယ်ဖြစ်ချင်တာလည်း ဖြစ်ရလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 5,
                    AnswerResult = "တွေ့ရပြီလို့မှတ်ပေတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 6,
                    AnswerResult = "ဒီအချိန် မတွေးနဲ့ဦးဗျ။ မကောင်းသေးဘူး။ တွေ့မှာလည်းမဟုတ်ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 7,
                    AnswerResult = "တွေ့မှာ သေချာပါတယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 8,
                    AnswerResult = "ခင်ဗျားက တွေ့ဖို့ ကြိုးစားနေတာလား။ သူကလည်း တွေ့ချင်ပါသတဲ့ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 9,
                    AnswerResult = "အခုအချိန်မှာ တွေ့ဖို့ မကြိုးစားပါနဲ့ဦး။"
                },new AnswerModel()
                {
                    QuestionNo = 61,
                    AnswerNo = 10,
                    AnswerResult = "တွေ့မှာပါဗျာ။ မပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 1,
                    AnswerResult = "အကြံအစည်အောင်မှာပါဗျာ။ ရေကန်နှစ်ကန်ကရေကို ခပ်ပြီးရေချိုးလိုက်စမ်းပါ။ ပိုပြီးသေချာသွားတာပေ့ါ။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 2,
                    AnswerResult = "အဓိဌာန်(၉)ရက် ဝင်လိုက်ပါ။ အောင်မြင်သွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 3,
                    AnswerResult = "အိပ်ယာရွှေ့အိပ်လိုက်ပါ။ အောင်မြင်သွားပါလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 4,
                    AnswerResult = "အောင်မှာသေချာပါတယ်။ အောင်…...အောင်….......လို့တောင် မြည်နေပါပြီ။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 5,
                    AnswerResult = "အောင်မှာသေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 6,
                    AnswerResult = "အောင်ပြီလို့မှတ်ပေတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 7,
                    AnswerResult = "ဘုန်းကြီးပင့်ပြီး ဆွမ်းကပ်လိုက်ပါဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 8,
                    AnswerResult = "အောင်မြင်ပြီလို့မှတ်ပေတော့။ မလွဲတော့ဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 9,
                    AnswerResult = "မေတ္တာပို့ပြီး အလုပ်လုပ်ပါဗျာ။ အောင်မှာသေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 62,
                    AnswerNo = 10,
                    AnswerResult = "အောင်ပြီလို့ သဘောထားပေတော့။ ဘာမှမပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 1,
                    AnswerResult = "ကျိန်းသေအထမြောက်ပါမယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 2,
                    AnswerResult = "ယောဂီဝတ်နဲ့ (၉)ရက်လောက် အဓိဌာန်ဝင်လိုက်ပါ။ ပြီးမှ အဲ့အလုပ်ကိုလုပ်ပါ။ မုချအောင်မြင်မယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 3,
                    AnswerResult = "အိပ်ယာရွှေ့ပြီးအိပ်မှ အဲ့ဒီအလုပ်ကိုလုပ်ပါ။ မုချအောင်မြင်မယ်ဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 4,
                    AnswerResult = "အောင်မြင်မှာပါဗျာ။ လုပ်ဖြစ်အောင်သာ လုပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 5,
                    AnswerResult = "အောင်မြင်ဖို့ သေချာနေပါပြီ။ ဘာဖြစ်လို့ မေးနေတာလဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 6,
                    AnswerResult = "ရာခိုင်နှုန်းအပြည့် အောင်မြင်လိမ့်မယ်။ ပူကိုမပူပါနဲ့။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 7,
                    AnswerResult = "ဘုန်းတော်ကြီးတစ်ပါးကို ဆွမ်းကပ်ပြီးမှလုပ်ပါ။ အောင်မြင်ဖို့များပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 8,
                    AnswerResult = "ခင်ဗျားလုပ်မှကို အောင်မြင်မှာနော်။ တစ်ခြားလူလုပ်ရင် အဲ့ဒါကြီး ပျက်သွားလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 9,
                    AnswerResult = "မေတ္တာသုတ်ရွတ်ပြီး လုပ်စမ်းပါဗျာ။ အောင်မြင်ပါတယ်။ သင်လုပ်ဖို့ကို စောင့်နေတဲ့ အတိုင်းပါပဲ။"
                },new AnswerModel()
                {
                    QuestionNo = 63,
                    AnswerNo = 10,
                    AnswerResult = "အောင်ပါပြီဗျာ။ အချိန်ကုန်ခံပြီး ခင်ဗျားတို့မေးနေတယ်။ လုပ်လိုက်ပေတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 1,
                    AnswerResult = "စပေတော့။ အနားမှာ ဓါးရှည်တစ်ချောင်း ထောင်ထားဖို့လိုတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 2,
                    AnswerResult = "စပေတော့။ အနားမှာ လူတစ်ရပ်လောက်ရှိတဲ့ သစ်ကိုင်းဖြောင့်ဖြောင့်တစ်ချောင်း ထောင်ထားဖို့လိုတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 3,
                    AnswerResult = "ဒီအချိန်မစပါနဲ့ဦး။ ဒီကနေ(၈)ရက်ပြည့်ပြီး (၉)ရက်မြောက်တဲ့နေ့မှ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 4,
                    AnswerResult = "ပန်းအဝါ(၉)ပွင့် အိုးထဲမှာထိုးပြီး အနားမှာထား၍ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 5,
                    AnswerResult = "ဒီအချိန် မစပါနဲ့ဦး။ ဒီကနေ (၁၈)ရက်ကျော်မှ အခါကောင်းမိမယ်။ စောင့်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 6,
                    AnswerResult = "ဒီနေ့မနက်ပဲ (၂)ရက်တိတိ စောင့်လိုက်ပါ။ အဲ့ဒီကျမှ အခါကောင်းတွေ့လိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 7,
                    AnswerResult = "လောလောဆယ် မစနဲ့ဦး။ သင်တို့အုပ်စု၊ သင်တို့အပေါင်းအသင်းထဲက တစ်ယောက်ယောက် ခရီးထွက်လိမ့်မယ်။ အဲ့ဒီကျမှ စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 8,
                    AnswerResult = "အခုအခါမိနေပြီ။ မနက်ဖြန်မနက် (၄)နာရီမှာ စလိုက်ပေတော့။ အမွှေးတိုင်(၄)တိုင် ထွန်းပြီးစရင် ပိုကောင်းပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 9,
                    AnswerResult = "စပေတေ့ာ။ စတဲ့အခါမှာ စားပွဲတင်နာရီ ဒါမှမဟုတ် နံရံကပ်နာရီ အဝိုင်းတစ်ခု အနားမှာထားပြီး စလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 9,
                    AnswerResult = "အိမ်ထောင်ကျပြီးလျှင် နေရန်အတွက် အိမ်ပင်ဝယ်ထားပြီး မဟုတ်ပါလော။"
                },new AnswerModel()
                {
                    QuestionNo = 64,
                    AnswerNo = 10,
                    AnswerResult = "ဘုရားစင်မှာ သောက်တော်ရေ(၉)ခွက်လှူပြီး သင့်ရဲ့လုပ်ငန်းကို စလိုက်ပါ။ အားလုံးအဆင်ပြေသွားပါလိမ့်မယ်။"
                }
            };
        }
    }
}
