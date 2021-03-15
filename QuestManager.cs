using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestManager : MonoBehaviour
{


    public StringValue Sahne;



    public static float order=1;
    public FloatValue ORDER;

    public Quest quest = new Quest();
    public GameObject questPrintBox;
    public GameObject buttonPrefab;
    //public GameObject victoryPopup;



    QuestEvent final;


    public GameObject[] görev;



    void Start()
    {
        order = ORDER.RuntimeValue;


        //create each event

        QuestEvent qe0 = quest.AddQuestEvent("loading", " ", görev[0]);
        QuestEvent qe1 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev1_t"),LocalizationManager.instance.GetLocalizedValue("görev1"), görev[1]);
        QuestEvent qe2 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev2_t"), LocalizationManager.instance.GetLocalizedValue("görev2"), görev[2]);
        QuestEvent qe3 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev3_t"), LocalizationManager.instance.GetLocalizedValue("görev3"), görev[3]);
        QuestEvent qe4 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev4_t"), LocalizationManager.instance.GetLocalizedValue("görev4"), görev[4]);
        QuestEvent qe5 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev5_t"), LocalizationManager.instance.GetLocalizedValue("görev5"), görev[5]);
        QuestEvent qe6 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev6_t"), LocalizationManager.instance.GetLocalizedValue("görev6"), görev[6]);
        QuestEvent qe7 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev7_t"), LocalizationManager.instance.GetLocalizedValue("görev7"), görev[7]);
        QuestEvent qe8 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev8_t"), LocalizationManager.instance.GetLocalizedValue("görev8"), görev[8]);
        QuestEvent qe9 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev9_t"), LocalizationManager.instance.GetLocalizedValue("görev9"), görev[9]);
        QuestEvent qe10 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev10_t"), LocalizationManager.instance.GetLocalizedValue("görev10"), görev[10]);
        QuestEvent qe11 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev11_t"), LocalizationManager.instance.GetLocalizedValue("görev11"), görev[11]);
        QuestEvent qe12 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev12_t"), LocalizationManager.instance.GetLocalizedValue("görev12"), görev[12]);
        QuestEvent qe13 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev13_t"), LocalizationManager.instance.GetLocalizedValue("görev13"), görev[13]);
        QuestEvent qe14 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev14_t"), LocalizationManager.instance.GetLocalizedValue("görev14"), görev[14]);
        QuestEvent qe15 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev15_t"), LocalizationManager.instance.GetLocalizedValue("görev15"), görev[15]);
        QuestEvent qe16 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev16_t"), LocalizationManager.instance.GetLocalizedValue("görev16"), görev[16]);
        QuestEvent qe17 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev17_t"), LocalizationManager.instance.GetLocalizedValue("görev17"), görev[17]);
        QuestEvent qe18 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev18_t"), LocalizationManager.instance.GetLocalizedValue("görev18"), görev[18]);
        QuestEvent qe19 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev19_t"), LocalizationManager.instance.GetLocalizedValue("görev19"), görev[19]);
        QuestEvent qe20 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev20_t"), LocalizationManager.instance.GetLocalizedValue("görev20"), görev[20]);
        QuestEvent qe21 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev21_t"), LocalizationManager.instance.GetLocalizedValue("görev21"), görev[21]);
        QuestEvent qe22 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev22_t"), LocalizationManager.instance.GetLocalizedValue("görev22"), görev[22]);
        QuestEvent qe23 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev23_t"), LocalizationManager.instance.GetLocalizedValue("görev23"), görev[23]);
        QuestEvent qe24 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev24_t"), LocalizationManager.instance.GetLocalizedValue("görev24"), görev[24]);
        QuestEvent qe25 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev25_t"), LocalizationManager.instance.GetLocalizedValue("görev25"), görev[25]);
        QuestEvent qe26 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev26_t"), LocalizationManager.instance.GetLocalizedValue("görev26"), görev[26]);
        QuestEvent qe27 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev27_t"), LocalizationManager.instance.GetLocalizedValue("görev27"), görev[27]);
        QuestEvent qe28 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev28_t"), LocalizationManager.instance.GetLocalizedValue("görev28"), görev[28]);
        QuestEvent qe29 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev29_t"), LocalizationManager.instance.GetLocalizedValue("görev29"), görev[29]);
        QuestEvent qe30 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev30_t"), LocalizationManager.instance.GetLocalizedValue("görev30"), görev[30]);
        QuestEvent qe31 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev31_t"), LocalizationManager.instance.GetLocalizedValue("görev31"), görev[31]);
        QuestEvent qe32 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev32_t"), LocalizationManager.instance.GetLocalizedValue("görev32"), görev[32]);
        QuestEvent qe33 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev33_t"), LocalizationManager.instance.GetLocalizedValue("görev33"), görev[33]);
        QuestEvent qe34 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev34_t"), LocalizationManager.instance.GetLocalizedValue("görev34"), görev[34]);
        QuestEvent qe35 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev35_t"), LocalizationManager.instance.GetLocalizedValue("görev35"), görev[35]);
        QuestEvent qe36 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev36_t"), LocalizationManager.instance.GetLocalizedValue("görev36"), görev[36]);
        QuestEvent qe37 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev37_t"), LocalizationManager.instance.GetLocalizedValue("görev37"), görev[37]);
        QuestEvent qe38 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev38_t"), LocalizationManager.instance.GetLocalizedValue("görev38"), görev[38]);
        QuestEvent qe39 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev39_t"), LocalizationManager.instance.GetLocalizedValue("görev39"), görev[39]);
        QuestEvent qe40 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev40_t"), LocalizationManager.instance.GetLocalizedValue("görev40"), görev[40]);
        QuestEvent qe41 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev41_t"), LocalizationManager.instance.GetLocalizedValue("görev41"), görev[41]);
        QuestEvent qe42 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev42_t"), LocalizationManager.instance.GetLocalizedValue("görev42"), görev[42]);
        QuestEvent qe43 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev43_t"), LocalizationManager.instance.GetLocalizedValue("görev43"), görev[43]);
        QuestEvent qe44 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev44_t"), LocalizationManager.instance.GetLocalizedValue("görev44"), görev[44]);
        QuestEvent qe45 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev45_t"), LocalizationManager.instance.GetLocalizedValue("görev45"), görev[45]);
        QuestEvent qe46 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev46_t"), LocalizationManager.instance.GetLocalizedValue("görev46"), görev[46]);
        QuestEvent qe47 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev47_t"), LocalizationManager.instance.GetLocalizedValue("görev47"), görev[47]);
        QuestEvent qe48 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev48_t"), LocalizationManager.instance.GetLocalizedValue("görev48"), görev[48]);
        QuestEvent qe49 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev49_t"), LocalizationManager.instance.GetLocalizedValue("görev49"), görev[49]);
        QuestEvent qe50 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev50_t"), LocalizationManager.instance.GetLocalizedValue("görev50"), görev[50]);
        QuestEvent qe51 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev51_t"), LocalizationManager.instance.GetLocalizedValue("görev51"), görev[51]);
        QuestEvent qe52 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev52_t"), LocalizationManager.instance.GetLocalizedValue("görev52"), görev[52]);
        QuestEvent qe53 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev53_t"), LocalizationManager.instance.GetLocalizedValue("görev53"), görev[53]);
        QuestEvent qe54 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev54_t"), LocalizationManager.instance.GetLocalizedValue("görev54"), görev[54]);
        QuestEvent qe55 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev55_t"), LocalizationManager.instance.GetLocalizedValue("görev55"), görev[55]);
        QuestEvent qe56 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev56_t"), LocalizationManager.instance.GetLocalizedValue("görev56"), görev[56]);
        QuestEvent qe57 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev57_t"), LocalizationManager.instance.GetLocalizedValue("görev57"), görev[57]);
        QuestEvent qe58 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev58_t"), LocalizationManager.instance.GetLocalizedValue("görev58"), görev[58]);
        QuestEvent qe59 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev59_t"), LocalizationManager.instance.GetLocalizedValue("görev59"), görev[59]);
        QuestEvent qe60 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev60_t"), LocalizationManager.instance.GetLocalizedValue("görev60"), görev[60]);
        QuestEvent qe61 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev61_t"), LocalizationManager.instance.GetLocalizedValue("görev61"), görev[61]);
        QuestEvent qe62 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev62_t"), LocalizationManager.instance.GetLocalizedValue("görev62"), görev[62]);
        QuestEvent qe63 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev63_t"), LocalizationManager.instance.GetLocalizedValue("görev63"), görev[63]);
        QuestEvent qe64 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev64_t"), LocalizationManager.instance.GetLocalizedValue("görev64"), görev[64]);
        QuestEvent qe65 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev65_t"), LocalizationManager.instance.GetLocalizedValue("görev65"), görev[65]);
        QuestEvent qe66 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev66_t"), LocalizationManager.instance.GetLocalizedValue("görev66"), görev[66]);
        QuestEvent qe67 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev67_t"), LocalizationManager.instance.GetLocalizedValue("görev67"), görev[67]);
        QuestEvent qe68 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev68_t"), LocalizationManager.instance.GetLocalizedValue("görev68"), görev[68]);
        QuestEvent qe69 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev69_t"), LocalizationManager.instance.GetLocalizedValue("görev69"), görev[69]);
        QuestEvent qe70 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev70_t"), LocalizationManager.instance.GetLocalizedValue("görev70"), görev[70]);
        QuestEvent qe71 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev71_t"), LocalizationManager.instance.GetLocalizedValue("görev71"), görev[71]);
        QuestEvent qe72 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev72_t"), LocalizationManager.instance.GetLocalizedValue("görev72"), görev[72]);
        QuestEvent qe73 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev73_t"), LocalizationManager.instance.GetLocalizedValue("görev73"), görev[73]);
        QuestEvent qe74 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev74_t"), LocalizationManager.instance.GetLocalizedValue("görev74"), görev[74]);
        QuestEvent qe75 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev75_t"), LocalizationManager.instance.GetLocalizedValue("görev75"), görev[75]);
        QuestEvent qe76 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev76_t"), LocalizationManager.instance.GetLocalizedValue("görev76"), görev[76]);
        QuestEvent qe77 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev77_t"), LocalizationManager.instance.GetLocalizedValue("görev77"), görev[77]);
        QuestEvent qe78 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev78_t"), LocalizationManager.instance.GetLocalizedValue("görev78"), görev[78]);
        QuestEvent qe79 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev79_t"), LocalizationManager.instance.GetLocalizedValue("görev79"), görev[79]);
        QuestEvent qe80 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev80_t"), LocalizationManager.instance.GetLocalizedValue("görev80"), görev[80]);
        QuestEvent qe81 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev81_t"), LocalizationManager.instance.GetLocalizedValue("görev81"), görev[81]);
        QuestEvent qe82 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev82_t"), LocalizationManager.instance.GetLocalizedValue("görev82"), görev[82]);
        QuestEvent qe83 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev83_t"), LocalizationManager.instance.GetLocalizedValue("görev83"), görev[83]);
        QuestEvent qe84 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev84_t"), LocalizationManager.instance.GetLocalizedValue("görev84"), görev[84]);
        QuestEvent qe85 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev85_t"), LocalizationManager.instance.GetLocalizedValue("görev85"), görev[85]);
        QuestEvent qe86 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev86_t"), LocalizationManager.instance.GetLocalizedValue("görev86"), görev[86]);
        QuestEvent qe87 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev87_t"), LocalizationManager.instance.GetLocalizedValue("görev87"), görev[87]);
        QuestEvent qe88 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev88_t"), LocalizationManager.instance.GetLocalizedValue("görev88"), görev[88]);
        QuestEvent qe89 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev89_t"), LocalizationManager.instance.GetLocalizedValue("görev89"), görev[89]);
        QuestEvent qe90 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev90_t"), LocalizationManager.instance.GetLocalizedValue("görev90"), görev[90]);
        QuestEvent qe91 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev91_t"), LocalizationManager.instance.GetLocalizedValue("görev91"), görev[91]);
        QuestEvent qe92 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev92_t"), LocalizationManager.instance.GetLocalizedValue("görev92"), görev[92]);
        QuestEvent qe93 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev93_t"), LocalizationManager.instance.GetLocalizedValue("görev93"), görev[93]);
        QuestEvent qe94 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev94_t"), LocalizationManager.instance.GetLocalizedValue("görev94"), görev[94]);
        QuestEvent qe95 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev95_t"), LocalizationManager.instance.GetLocalizedValue("görev95"), görev[95]);
        QuestEvent qe96 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev96_t"), LocalizationManager.instance.GetLocalizedValue("görev96"), görev[96]);
        QuestEvent qe97 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev97_t"), LocalizationManager.instance.GetLocalizedValue("görev97"), görev[97]);
        QuestEvent qe98 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev98_t"), LocalizationManager.instance.GetLocalizedValue("görev98"), görev[98]);
        QuestEvent qe99 = quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev99_t"), LocalizationManager.instance.GetLocalizedValue("görev99"), görev[99]);
        QuestEvent qe100= quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev100_t"), LocalizationManager.instance.GetLocalizedValue("görev100"), görev[100]);
        QuestEvent qe101= quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev101_t"), LocalizationManager.instance.GetLocalizedValue("görev101"), görev[101]);
        QuestEvent qe102= quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev102_t"), LocalizationManager.instance.GetLocalizedValue("görev102"), görev[102]);
        QuestEvent qe103= quest.AddQuestEvent(LocalizationManager.instance.GetLocalizedValue("görev103_t"), LocalizationManager.instance.GetLocalizedValue("görev103"), görev[103]);
      





        //define the paths between the events -e.g.- the order must be completed

        quest.AddPath(qe0.GetId(), qe1.GetId());
        quest.AddPath(qe1.GetId(), qe2.GetId());
        quest.AddPath(qe2.GetId(), qe3.GetId());
        quest.AddPath(qe3.GetId(), qe4.GetId());
        quest.AddPath(qe4.GetId(), qe5.GetId());
        quest.AddPath(qe5.GetId(), qe6.GetId());
        quest.AddPath(qe6.GetId(), qe7.GetId());
        quest.AddPath(qe7.GetId(), qe8.GetId());
        quest.AddPath(qe8.GetId(), qe9.GetId());
        quest.AddPath(qe9.GetId(), qe10.GetId());
        quest.AddPath(qe10.GetId(), qe11.GetId());
        quest.AddPath(qe11.GetId(), qe12.GetId());
        quest.AddPath(qe12.GetId(), qe13.GetId());
        quest.AddPath(qe13.GetId(), qe14.GetId());
        quest.AddPath(qe14.GetId(), qe15.GetId());
        quest.AddPath(qe15.GetId(), qe16.GetId());
        quest.AddPath(qe16.GetId(), qe17.GetId());
        quest.AddPath(qe17.GetId(), qe18.GetId());
        quest.AddPath(qe18.GetId(), qe19.GetId());
        quest.AddPath(qe19.GetId(), qe20.GetId());
        quest.AddPath(qe20.GetId(), qe21.GetId());
        quest.AddPath(qe21.GetId(), qe22.GetId());
        quest.AddPath(qe22.GetId(), qe23.GetId());
        quest.AddPath(qe23.GetId(), qe24.GetId());
        quest.AddPath(qe24.GetId(), qe25.GetId());
        quest.AddPath(qe25.GetId(), qe26.GetId());
        quest.AddPath(qe26.GetId(), qe27.GetId());
        quest.AddPath(qe27.GetId(), qe28.GetId());
        quest.AddPath(qe28.GetId(), qe29.GetId());
        quest.AddPath(qe29.GetId(), qe30.GetId());
        quest.AddPath(qe30.GetId(), qe31.GetId());
        quest.AddPath(qe31.GetId(), qe32.GetId());
        quest.AddPath(qe32.GetId(), qe33.GetId());
        quest.AddPath(qe33.GetId(), qe34.GetId());
        quest.AddPath(qe34.GetId(), qe35.GetId());
        quest.AddPath(qe35.GetId(), qe36.GetId());
        quest.AddPath(qe36.GetId(), qe37.GetId());
        quest.AddPath(qe37.GetId(), qe38.GetId());
        quest.AddPath(qe38.GetId(), qe39.GetId());
        quest.AddPath(qe39.GetId(), qe40.GetId());
        quest.AddPath(qe40.GetId(), qe41.GetId());
        quest.AddPath(qe41.GetId(), qe42.GetId());
        quest.AddPath(qe42.GetId(), qe43.GetId());
        quest.AddPath(qe43.GetId(), qe44.GetId());
        quest.AddPath(qe44.GetId(), qe45.GetId());
        quest.AddPath(qe45.GetId(), qe46.GetId());
        quest.AddPath(qe46.GetId(), qe47.GetId());
        quest.AddPath(qe47.GetId(), qe48.GetId());
        quest.AddPath(qe48.GetId(), qe49.GetId());
        quest.AddPath(qe49.GetId(), qe50.GetId());
        quest.AddPath(qe50.GetId(), qe51.GetId());
        quest.AddPath(qe51.GetId(), qe52.GetId());
        quest.AddPath(qe52.GetId(), qe53.GetId());
        quest.AddPath(qe53.GetId(), qe54.GetId());
        quest.AddPath(qe54.GetId(), qe55.GetId());
        quest.AddPath(qe55.GetId(), qe56.GetId());
        quest.AddPath(qe56.GetId(), qe57.GetId());
        quest.AddPath(qe57.GetId(), qe58.GetId());
        quest.AddPath(qe58.GetId(), qe59.GetId());
        quest.AddPath(qe59.GetId(), qe60.GetId());
        quest.AddPath(qe60.GetId(), qe61.GetId());
        quest.AddPath(qe61.GetId(), qe62.GetId());
        quest.AddPath(qe62.GetId(), qe63.GetId());
        quest.AddPath(qe63.GetId(), qe64.GetId());
        quest.AddPath(qe64.GetId(), qe65.GetId());
        quest.AddPath(qe65.GetId(), qe66.GetId());
        quest.AddPath(qe66.GetId(), qe67.GetId());
        quest.AddPath(qe67.GetId(), qe68.GetId());
        quest.AddPath(qe68.GetId(), qe69.GetId());
        quest.AddPath(qe69.GetId(), qe70.GetId());
        quest.AddPath(qe70.GetId(), qe71.GetId());
        quest.AddPath(qe71.GetId(), qe72.GetId());
        quest.AddPath(qe72.GetId(), qe73.GetId());
        quest.AddPath(qe73.GetId(), qe74.GetId());
        quest.AddPath(qe74.GetId(), qe75.GetId());
        quest.AddPath(qe75.GetId(), qe76.GetId());
        quest.AddPath(qe76.GetId(), qe77.GetId());
        quest.AddPath(qe77.GetId(), qe78.GetId());
        quest.AddPath(qe78.GetId(), qe79.GetId());
        quest.AddPath(qe79.GetId(), qe80.GetId());
        quest.AddPath(qe80.GetId(), qe81.GetId());
        quest.AddPath(qe81.GetId(), qe82.GetId());
        quest.AddPath(qe82.GetId(), qe83.GetId());
        quest.AddPath(qe83.GetId(), qe84.GetId());
        quest.AddPath(qe84.GetId(), qe85.GetId());
        quest.AddPath(qe85.GetId(), qe86.GetId());
        quest.AddPath(qe86.GetId(), qe87.GetId());
        quest.AddPath(qe87.GetId(), qe88.GetId());
        quest.AddPath(qe88.GetId(), qe89.GetId());
        quest.AddPath(qe89.GetId(), qe90.GetId());
        quest.AddPath(qe90.GetId(), qe91.GetId());
        quest.AddPath(qe91.GetId(), qe92.GetId());
        quest.AddPath(qe92.GetId(), qe93.GetId());
        quest.AddPath(qe93.GetId(), qe94.GetId());
        quest.AddPath(qe94.GetId(), qe95.GetId());
        quest.AddPath(qe95.GetId(), qe96.GetId());
        quest.AddPath(qe96.GetId(), qe97.GetId());
        quest.AddPath(qe97.GetId(), qe98.GetId());
        quest.AddPath(qe98.GetId(), qe99.GetId());
        quest.AddPath(qe99.GetId(), qe100.GetId());
        quest.AddPath(qe100.GetId(), qe101.GetId());
        quest.AddPath(qe101.GetId(), qe102.GetId());
       quest.AddPath(qe102.GetId(), qe103.GetId());



        quest.BFS(qe0.GetId());

        QuestButton button = CreateButton(qe0).GetComponent<QuestButton>();
        görev[0].GetComponent<QuestLocations>().Setup(this, qe0, button);
        button = CreateButton(qe1).GetComponent<QuestButton>();
        görev[1].GetComponent<QuestLocations>().Setup(this, qe1, button);
        button = CreateButton(qe2).GetComponent<QuestButton>();
        görev[2].GetComponent<QuestLocations>().Setup(this, qe2, button);
        button = CreateButton(qe3).GetComponent<QuestButton>();
        görev[3].GetComponent<QuestLocations>().Setup(this, qe3, button);
        button = CreateButton(qe4).GetComponent<QuestButton>();
        görev[4].GetComponent<QuestLocations>().Setup(this, qe4, button);
        button = CreateButton(qe5).GetComponent<QuestButton>();
        görev[5].GetComponent<QuestLocations>().Setup(this, qe5, button);
        button = CreateButton(qe6).GetComponent<QuestButton>();
        görev[6].GetComponent<QuestLocations>().Setup(this, qe6, button);
        button = CreateButton(qe7).GetComponent<QuestButton>();
        görev[7].GetComponent<QuestLocations>().Setup(this, qe7, button);
        button = CreateButton(qe8).GetComponent<QuestButton>();
        görev[8].GetComponent<QuestLocations>().Setup(this, qe8, button);
        button = CreateButton(qe9).GetComponent<QuestButton>();
        görev[9].GetComponent<QuestLocations>().Setup(this, qe9, button);
        button = CreateButton(qe10).GetComponent<QuestButton>();
        görev[10].GetComponent<QuestLocations>().Setup(this, qe10, button);
        button = CreateButton(qe11).GetComponent<QuestButton>();
        görev[11].GetComponent<QuestLocations>().Setup(this, qe11, button);
        button = CreateButton(qe12).GetComponent<QuestButton>();
        görev[12].GetComponent<QuestLocations>().Setup(this, qe12, button);
        button = CreateButton(qe13).GetComponent<QuestButton>();
        görev[13].GetComponent<QuestLocations>().Setup(this, qe13, button);
        button = CreateButton(qe14).GetComponent<QuestButton>();
        görev[14].GetComponent<QuestLocations>().Setup(this, qe14, button);
        button = CreateButton(qe15).GetComponent<QuestButton>();
        görev[15].GetComponent<QuestLocations>().Setup(this, qe15, button);
        button = CreateButton(qe16).GetComponent<QuestButton>();
        görev[16].GetComponent<QuestLocations>().Setup(this, qe16, button);
        button = CreateButton(qe17).GetComponent<QuestButton>();
        görev[17].GetComponent<QuestLocations>().Setup(this, qe17, button);
        button = CreateButton(qe18).GetComponent<QuestButton>();
        görev[18].GetComponent<QuestLocations>().Setup(this, qe18, button);
        button = CreateButton(qe19).GetComponent<QuestButton>();
        görev[19].GetComponent<QuestLocations>().Setup(this, qe19, button);
        button = CreateButton(qe20).GetComponent<QuestButton>();
        görev[20].GetComponent<QuestLocations>().Setup(this, qe20, button);
        button = CreateButton(qe21).GetComponent<QuestButton>();
        görev[21].GetComponent<QuestLocations>().Setup(this, qe21, button);
        button = CreateButton(qe22).GetComponent<QuestButton>();
        görev[22].GetComponent<QuestLocations>().Setup(this, qe22, button);
        button = CreateButton(qe23).GetComponent<QuestButton>();
        görev[23].GetComponent<QuestLocations>().Setup(this, qe23, button);
        button = CreateButton(qe24).GetComponent<QuestButton>();
        görev[24].GetComponent<QuestLocations>().Setup(this, qe24, button);
        button = CreateButton(qe25).GetComponent<QuestButton>();
        görev[25].GetComponent<QuestLocations>().Setup(this, qe25, button);
        button = CreateButton(qe26).GetComponent<QuestButton>();
        görev[26].GetComponent<QuestLocations>().Setup(this, qe26, button);
        button = CreateButton(qe27).GetComponent<QuestButton>();
        görev[27].GetComponent<QuestLocations>().Setup(this, qe27, button);
        button = CreateButton(qe28).GetComponent<QuestButton>();
        görev[28].GetComponent<QuestLocations>().Setup(this, qe28, button);
        button = CreateButton(qe29).GetComponent<QuestButton>();
        görev[29].GetComponent<QuestLocations>().Setup(this, qe29, button);
        button = CreateButton(qe30).GetComponent<QuestButton>();
        görev[30].GetComponent<QuestLocations>().Setup(this, qe30, button);
        button = CreateButton(qe31).GetComponent<QuestButton>();
        görev[31].GetComponent<QuestLocations>().Setup(this, qe31, button);
        button = CreateButton(qe32).GetComponent<QuestButton>();
        görev[32].GetComponent<QuestLocations>().Setup(this, qe32, button);
        button = CreateButton(qe33).GetComponent<QuestButton>();
        görev[33].GetComponent<QuestLocations>().Setup(this, qe33, button);
        button = CreateButton(qe34).GetComponent<QuestButton>();
        görev[34].GetComponent<QuestLocations>().Setup(this, qe34, button);
        button = CreateButton(qe35).GetComponent<QuestButton>();
        görev[35].GetComponent<QuestLocations>().Setup(this, qe35, button);
        button = CreateButton(qe36).GetComponent<QuestButton>();
        görev[36].GetComponent<QuestLocations>().Setup(this, qe36, button);
        button = CreateButton(qe37).GetComponent<QuestButton>();
        görev[37].GetComponent<QuestLocations>().Setup(this, qe37, button);
        button = CreateButton(qe38).GetComponent<QuestButton>();
        görev[38].GetComponent<QuestLocations>().Setup(this, qe38, button);
        button = CreateButton(qe39).GetComponent<QuestButton>();
        görev[39].GetComponent<QuestLocations>().Setup(this, qe39, button);
        button = CreateButton(qe40).GetComponent<QuestButton>();
        görev[40].GetComponent<QuestLocations>().Setup(this, qe40, button);
        button = CreateButton(qe41).GetComponent<QuestButton>();
        görev[41].GetComponent<QuestLocations>().Setup(this, qe41, button);
        button = CreateButton(qe42).GetComponent<QuestButton>();
        görev[42].GetComponent<QuestLocations>().Setup(this, qe42, button);
        button = CreateButton(qe43).GetComponent<QuestButton>();
        görev[43].GetComponent<QuestLocations>().Setup(this, qe43, button);
        button = CreateButton(qe44).GetComponent<QuestButton>();
        görev[44].GetComponent<QuestLocations>().Setup(this, qe44, button);
        button = CreateButton(qe45).GetComponent<QuestButton>();
        görev[45].GetComponent<QuestLocations>().Setup(this, qe45, button);
        button = CreateButton(qe46).GetComponent<QuestButton>();
        görev[46].GetComponent<QuestLocations>().Setup(this, qe46, button);
        button = CreateButton(qe47).GetComponent<QuestButton>();
        görev[47].GetComponent<QuestLocations>().Setup(this, qe47, button);
        button = CreateButton(qe48).GetComponent<QuestButton>();
        görev[48].GetComponent<QuestLocations>().Setup(this, qe48, button);
        button = CreateButton(qe49).GetComponent<QuestButton>();
        görev[49].GetComponent<QuestLocations>().Setup(this, qe49, button);
        button = CreateButton(qe50).GetComponent<QuestButton>();
        görev[50].GetComponent<QuestLocations>().Setup(this, qe50, button);
        button = CreateButton(qe51).GetComponent<QuestButton>();
        görev[51].GetComponent<QuestLocations>().Setup(this, qe51, button);
        button = CreateButton(qe52).GetComponent<QuestButton>();
        görev[52].GetComponent<QuestLocations>().Setup(this, qe52, button);
        button = CreateButton(qe53).GetComponent<QuestButton>();
        görev[53].GetComponent<QuestLocations>().Setup(this, qe53, button);
        button = CreateButton(qe54).GetComponent<QuestButton>();
        görev[54].GetComponent<QuestLocations>().Setup(this, qe54, button);
        button = CreateButton(qe55).GetComponent<QuestButton>();
        görev[55].GetComponent<QuestLocations>().Setup(this, qe55, button);
        button = CreateButton(qe56).GetComponent<QuestButton>();
        görev[56].GetComponent<QuestLocations>().Setup(this, qe56, button);
        button = CreateButton(qe57).GetComponent<QuestButton>();
        görev[57].GetComponent<QuestLocations>().Setup(this, qe57, button);
        button = CreateButton(qe58).GetComponent<QuestButton>();
        görev[58].GetComponent<QuestLocations>().Setup(this, qe58, button);
        button = CreateButton(qe59).GetComponent<QuestButton>();
        görev[59].GetComponent<QuestLocations>().Setup(this, qe59, button);
        button = CreateButton(qe60).GetComponent<QuestButton>();
        görev[60].GetComponent<QuestLocations>().Setup(this, qe60, button);
        button = CreateButton(qe61).GetComponent<QuestButton>();
        görev[61].GetComponent<QuestLocations>().Setup(this, qe61, button);
        button = CreateButton(qe62).GetComponent<QuestButton>();
        görev[62].GetComponent<QuestLocations>().Setup(this, qe62, button);
        button = CreateButton(qe63).GetComponent<QuestButton>();
        görev[63].GetComponent<QuestLocations>().Setup(this, qe63, button);
        button = CreateButton(qe64).GetComponent<QuestButton>();
        görev[64].GetComponent<QuestLocations>().Setup(this, qe64, button);
        button = CreateButton(qe65).GetComponent<QuestButton>();
        görev[65].GetComponent<QuestLocations>().Setup(this, qe65, button);
        button = CreateButton(qe66).GetComponent<QuestButton>();
        görev[66].GetComponent<QuestLocations>().Setup(this, qe66, button);
        button = CreateButton(qe67).GetComponent<QuestButton>();
        görev[67].GetComponent<QuestLocations>().Setup(this, qe67, button);
        button = CreateButton(qe68).GetComponent<QuestButton>();
        görev[68].GetComponent<QuestLocations>().Setup(this, qe68, button);
        button = CreateButton(qe69).GetComponent<QuestButton>();
        görev[69].GetComponent<QuestLocations>().Setup(this, qe69, button);
        button = CreateButton(qe70).GetComponent<QuestButton>();
        görev[70].GetComponent<QuestLocations>().Setup(this, qe70, button);
        button = CreateButton(qe71).GetComponent<QuestButton>();
        görev[71].GetComponent<QuestLocations>().Setup(this, qe71, button);
        button = CreateButton(qe72).GetComponent<QuestButton>();
        görev[72].GetComponent<QuestLocations>().Setup(this, qe72, button);
        button = CreateButton(qe73).GetComponent<QuestButton>();
        görev[73].GetComponent<QuestLocations>().Setup(this, qe73, button);
        button = CreateButton(qe74).GetComponent<QuestButton>();
        görev[74].GetComponent<QuestLocations>().Setup(this, qe74, button);
        button = CreateButton(qe75).GetComponent<QuestButton>();
        görev[75].GetComponent<QuestLocations>().Setup(this, qe75, button);
        button = CreateButton(qe76).GetComponent<QuestButton>();
        görev[76].GetComponent<QuestLocations>().Setup(this, qe76, button);
        button = CreateButton(qe77).GetComponent<QuestButton>();
        görev[77].GetComponent<QuestLocations>().Setup(this, qe77, button);
        button = CreateButton(qe78).GetComponent<QuestButton>();
        görev[78].GetComponent<QuestLocations>().Setup(this, qe78, button);
        button = CreateButton(qe79).GetComponent<QuestButton>();
        görev[79].GetComponent<QuestLocations>().Setup(this, qe79, button);
        button = CreateButton(qe80).GetComponent<QuestButton>();
        görev[80].GetComponent<QuestLocations>().Setup(this, qe80, button);
        button = CreateButton(qe81).GetComponent<QuestButton>();
        görev[81].GetComponent<QuestLocations>().Setup(this, qe81, button);
        button = CreateButton(qe82).GetComponent<QuestButton>();
        görev[82].GetComponent<QuestLocations>().Setup(this, qe82, button);
        button = CreateButton(qe83).GetComponent<QuestButton>();
        görev[83].GetComponent<QuestLocations>().Setup(this, qe83, button);
        button = CreateButton(qe84).GetComponent<QuestButton>();
        görev[84].GetComponent<QuestLocations>().Setup(this, qe84, button);
        button = CreateButton(qe85).GetComponent<QuestButton>();
        görev[85].GetComponent<QuestLocations>().Setup(this, qe85, button);
        button = CreateButton(qe86).GetComponent<QuestButton>();
        görev[86].GetComponent<QuestLocations>().Setup(this, qe86, button);
        button = CreateButton(qe87).GetComponent<QuestButton>();
        görev[87].GetComponent<QuestLocations>().Setup(this, qe87, button);
        button = CreateButton(qe88).GetComponent<QuestButton>();
        görev[88].GetComponent<QuestLocations>().Setup(this, qe88, button);
        button = CreateButton(qe89).GetComponent<QuestButton>();
        görev[89].GetComponent<QuestLocations>().Setup(this, qe89, button);
        button = CreateButton(qe90).GetComponent<QuestButton>();
        görev[90].GetComponent<QuestLocations>().Setup(this, qe90, button);
        button = CreateButton(qe91).GetComponent<QuestButton>();
        görev[91].GetComponent<QuestLocations>().Setup(this, qe91, button);
        button = CreateButton(qe92).GetComponent<QuestButton>();
        görev[92].GetComponent<QuestLocations>().Setup(this, qe92, button);
        button = CreateButton(qe93).GetComponent<QuestButton>();
        görev[93].GetComponent<QuestLocations>().Setup(this, qe93, button);
        button = CreateButton(qe94).GetComponent<QuestButton>();
        görev[94].GetComponent<QuestLocations>().Setup(this, qe94, button);
        button = CreateButton(qe95).GetComponent<QuestButton>();
        görev[95].GetComponent<QuestLocations>().Setup(this, qe95, button);
        button = CreateButton(qe96).GetComponent<QuestButton>();
        görev[96].GetComponent<QuestLocations>().Setup(this, qe96, button);
        button = CreateButton(qe97).GetComponent<QuestButton>();
        görev[97].GetComponent<QuestLocations>().Setup(this, qe97, button);
        button = CreateButton(qe98).GetComponent<QuestButton>();
        görev[98].GetComponent<QuestLocations>().Setup(this, qe98, button);
        button = CreateButton(qe99).GetComponent<QuestButton>();
        görev[99].GetComponent<QuestLocations>().Setup(this, qe99, button);
        button = CreateButton(qe100).GetComponent<QuestButton>();
        görev[100].GetComponent<QuestLocations>().Setup(this, qe100, button);
        button = CreateButton(qe101).GetComponent<QuestButton>();
        görev[101].GetComponent<QuestLocations>().Setup(this, qe101, button);
        button = CreateButton(qe102).GetComponent<QuestButton>();
        görev[102].GetComponent<QuestLocations>().Setup(this, qe102, button);
        button = CreateButton(qe103).GetComponent<QuestButton>();
        görev[103].GetComponent<QuestLocations>().Setup(this, qe103, button);

        //   final = qe7;

        // quest.PrintPath();



    }


 

    GameObject CreateButton(QuestEvent e)
    {
        GameObject b = Instantiate(buttonPrefab);
        b.GetComponent<QuestButton>().Setup(e, questPrintBox);

        if (e.order == 1)
        {
            b.GetComponent<QuestButton>().UpdateButton(QuestEvent.EventStatus.CURRENT);
            e.status = QuestEvent.EventStatus.CURRENT;
        }


        return b;
    }

    public void UpdateQuestsOnCompletion(QuestEvent e)
    {
        if (e == final)
        {
           // victoryPopup.SetActive(true);
            
            return;
        }

        if(e.order ==1)
            e.order = (int)order;




        foreach (QuestEvent n in quest.questEvents)
        {




            //if this event is the next in order
            if (n.order == e.order + 1)
            {
                //make the next in Line available for completion
                n.UpdateQuestEvent(QuestEvent.EventStatus.CURRENT);
                order = e.order;
                ORDER.RuntimeValue = order;
              //  GameSaveManager.Save();

            }



        }





    }


}
