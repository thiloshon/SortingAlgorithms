﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Data.Project01
{
    class MinDequesNumber_Generator
    {

        static public int Count()
        {
            return 53;
        }

        static public int Generate(int k, out int[] a1)
        {
            int result = -1; a1 = null;
            switch (k)
            {
                case 0: a1 = new int[]{ 50,45,55,60,65,40,70,35,30,75}; result = 1; break;
                case 1: a1 = new int[]{ 3,6,0,9,5,4}; result = 2; break;
                case 2: a1 = new int[]{ 0,2,1,4,3,6,5,8,7,9}; result = 5; break;
                case 3: a1 = new int[]{ -858,-790,-791,-750,-769,-571,-746,-464,-509,-439,-449,-416,-426,-388,-412,-369,-378,-316,-364,-279,-287,-123,-194,-48,-71,61,28,304,94,346,311,411,387,460,453,547,527,604,580,665,621,730,718,802,733,871,809,921,884,985}; result = 25; break;
                case 4: a1 = new int[]{ 902,878,895,860,869,791,829,772,784,731,759,651,665,541,586,409,534,264,405,230,247,159,224,36,124,-5,31,-177,-58,-327,-194,-357,-340,-474,-391,-494,-492,-508,-505,-577,-554,-723,-662,-824,-768,-908,-880,-975,-930,-993}; result = 25; break;
                case 5: a1 = new int[]{ -742,894,-499,905,744}; result = 2; break;
                case 6: a1 = new int[]{ -62,-249,505,975,124}; result = 2; break;
                case 7: a1 = new int[]{ -4,-721,-579,-26,335}; result = 2; break;
                case 8: a1 = new int[]{ 701,-952,-493,285}; result = 2; break;
                case 9: a1 = new int[]{ 592,164,-698,372,-896}; result = 2; break;
                case 10: a1 = new int[]{ 409,620,-656,896,-133}; result = 2; break;
                case 11: a1 = new int[]{ -881,428,-472,-212,-505}; result = 3; break;
                case 12: a1 = new int[]{ 380,59,-275,-60,-20}; result = 2; break;
                case 13: a1 = new int[]{ -687,-282,-368,75,-408}; result = 2; break;
                case 14: a1 = new int[]{ 807,770,584,-398,-252}; result = 2; break;
                case 15: a1 = new int[]{ -254,275,153}; result = 2; break;
                case 16: a1 = new int[]{ -209,135,-378,887,719}; result = 2; break;
                case 17: a1 = new int[]{ 120,197,829,857,692}; result = 2; break;
                case 18: a1 = new int[]{ -774,518,-183,317,-859}; result = 2; break;
                case 19: a1 = new int[]{ -990,187,562,-971}; result = 2; break;
                case 20: a1 = new int[]{ 248,-621,-889,380,-516}; result = 2; break;
                case 21: a1 = new int[]{ -882,-938,-391,654,-60}; result = 2; break;
                case 22: a1 = new int[]{ 331,765,413,521,609}; result = 2; break;
                case 23: a1 = new int[]{ 737,-965,-391,-721}; result = 2; break;
                case 24: a1 = new int[]{ 891,120,-117,400,764}; result = 2; break;
                case 25: a1 = new int[]{ 7,-770,-729,-198,-926}; result = 2; break;
                case 26: a1 = new int[]{ 849,-562,890,756}; result = 2; break;
                case 27: a1 = new int[]{ 265,92,-613,353,693}; result = 1; break;
                case 28: a1 = new int[]{ -91,-314,-653,-42}; result = 1; break;
                case 29: a1 = new int[]{ 475,855,-275,558,174}; result = 3; break;
                case 30: a1 = new int[]{ 362,-776,-449,-249,5}; result = 2; break;
                case 31: a1 = new int[]{ 818,-58,-75}; result = 1; break;
                case 32: a1 = new int[]{ -503,268,-826,360,649}; result = 1; break;
                case 33: a1 = new int[]{ -193,912,89,-744,-448}; result = 3; break;
                case 34: a1 = new int[]{ 549,-966,-838,-685,88,352,-266,242,803,199,-188,61,688,-621,679,546,-992,-450,-199,496,-822,-835,-566,285,-101,713,-804,858,465,200,-369,220,936,-19,801,-932,-459,-615,-408,-123,33,398,-354,-642,115,274,-384,298,163,259}; result = 19; break;
                case 35: a1 = new int[]{ 182,967,607,-923,327,769,-44,29,-610,-202,660,-824,-272,788,304,3,112,-7,850,658,-628,567,-363,-819,-203,-748,-679,530,-194,785,-318,-141,613,-241,-207,-625,711,-633,-184,-588,-907,-390,-54,214,576,806,-485,60,-541,-232}; result = 18; break;
                case 36: a1 = new int[]{ -77,876,385,575,-853,-843,-181,503,-534,538,-90,-198,-514,355,687,-247,811,-615,-508,582,-312,-171,-701,345,434,878,-621,566,520,-434,-945,640,977,-893,974,-597,-98,150,337,-990,-175,-140,86,69,-126,78,-885,814,752,47}; result = 17; break;
                case 37: a1 = new int[]{ 905,315,-635,431,-226,-931,-905,685,648,670,275,867,-156,165,192,-1000,-926,-400,787,-685,163,-385,-591,639,794,333,765,185,705,-720,-489,390,-648,144,745,371,-950,932,-223,922,994,-818,-920,181,87,-82,429,967,282,35}; result = 19; break;
                case 38: a1 = new int[]{ -269,241,-887,-702,697,-947,260,314,-633,13,-888,608,672,-7,236,-151,-828,-267,-938,113,-734,-180,822,-131,881,-601,659,-147,722,295,-602,-207,-746,263,302,734,389,-303,-659,-758,-451,647,-629,226,267,-72,-915,-739,-784,-521}; result = 16; break;
                case 39: a1 = new int[]{ 191,949,879,280,-149,442,479,484,-15,561,-323,-594,695,-681,427,660,828,-206,-437,-774,820,658,372,776,-902,645,915,631,576,-162,235,-235,-357,167,-151,-522,960,-475,797,679,245,514,130,-979,926,287,-297,91,-436,-258}; result = 13; break;
                case 40: a1 = new int[]{ 749,-828,388,-440,488,-577,-679,-961,262,-892,-541,-692,203,334,812,468,-64,429,3,172,-365,544,526,-339,-631,527,-9,-819,918,10,-111,440,616,161,-953,331,409,-166,-871,521,-492,259,-623,809,286,-903,-774,-427,548,-109}; result = 19; break;
                case 41: a1 = new int[]{ 970,-230,-669,-315,122,-611,396,-22,-134,812,-54,-890,-261,736,545,170,718,623,893,-487,982,-713,904,-132,-560,-818,-920,-499,-709,207,-604,380,-189,637,197,704,510,603,-893,-123,42,448,-678,174,-960,-275,-254,-166,-168,820}; result = 18; break;
                case 42: a1 = new int[]{ 582,380,-381,968,919,328,-105,251,459,-614,-431,992,124,689,-376,725,312,895,-617,-116,-853,-952,348,734,55,-981,362,-183,142,-121,995,-424,-919,-111,-259,-751,120,893,-430,901,-247,854,-28,320,587,-454,-58,-88,-360,-569}; result = 18; break;
                case 43: a1 = new int[]{ 50,49,48,47,46,45,44,43,42,41,40,39,38,37,36,35,34,33,32,31,30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1}; result = 1; break;
                case 44: a1 = new int[]{ 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50}; result = 1; break;
                case 45: a1 = new int[]{ -79,-86,-70,-61,-44,-221,-16,11,-222,-225,93,140,207,-261,230,-269,254,-377,-559,-589,-623,257,-659,284,299,-671,358,-752,-765,373,397,-784,424,-840,494,-856,525,-882,-886,-890,648,670,-904,-909,-920,687,743,791,839,-963}; result = 1; break;
                case 46: a1 = new int[]{ 902,878,895,860,869,791,829,772,784,731,759,651,665,541,586,409,534,264,405,230,247,159,224,36,124,-5,31,-177,-58,-327,-194,-357,-340,-474,-391,-494,-492,-508,-505,-577,-554,-723,-662,-824,-768,-880,-908,-975,-993}; result = 23; break;
                case 47: a1 = new int[]{ -858,-750,-769,-571,-746,-464,-509,-439,-449,-416,-426,-388,-412,-369,-378,-316,-364,-279,-287,-123,-194,-48,-71,61,28,304,94,346,311,411,387,460,453,547,527,604,580,665,621,730,718,802,733,871,809,921,884,985}; result = 24; break;
                case 48: a1 = new int[]{ 3,6,0,9,5,4,-1000,1000,999,-999,998,-998,997,-997}; result = 4; break;
                case 49: a1 = new int[]{ 0,1,7,3,4,8,6}; result = 2; break;
                case 50: a1 = new int[]{ 1,2,3,7,4,5,6,8,0,9}; result = 2; break;
                case 51: a1 = new int[]{ 1,3,7,5,6}; result = 2; break;
                case 52: a1 = new int[]{ 1,50,2,49,3,48,4,47,5,45,6,44,7,43,8,42,9,41,10,40,11,39,12,38,13,37,14,36,15,35,16,34,17,33,18,32,19,31,20,30,21,29,22,28,23,27,24,26,25}; result = 2; break;
            }
            return result;
        }
    }

}