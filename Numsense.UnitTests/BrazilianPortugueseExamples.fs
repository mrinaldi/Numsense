﻿module Ploeh.Numsense.BrazilianPortugueseExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                                              "zero",         0)>]
[<InlineData(                                                             " zero",         0)>]
[<InlineData(                                                             "zero ",         0)>]
[<InlineData(                                                          "  zero  ",         0)>]
[<InlineData(                                                              "Zero",         0)>]
[<InlineData(                                                              "ZERO",         0)>]
[<InlineData(                                                           " zERo\t",         0)>]
[<InlineData(                                                                "um",         1)>]
[<InlineData(                                                                "UM",         1)>]
[<InlineData(                                                              "dois",         2)>]
[<InlineData(                                                             " dois",         2)>]
[<InlineData(                                                              "três",         3)>]
[<InlineData(                                                            "três  ",         3)>]
[<InlineData(                                                            "quatro",         4)>]
[<InlineData(                                                         "  quatro ",         4)>]
[<InlineData(                                                             "cinco",         5)>]
[<InlineData(                                                             "CincO",         5)>]
[<InlineData(                                                              "seis",         6)>]
[<InlineData(                                                          "  SEIS  ",         6)>]
[<InlineData(                                                              "sete",         7)>]
[<InlineData(                                                          "    seTe",         7)>]
[<InlineData(                                                              "oito",         8)>]
[<InlineData(                                                              "oITO",         8)>]
[<InlineData(                                                              "nove",         9)>]
[<InlineData(                                                            "NoVe  ",         9)>]
[<InlineData(                                                              "dez",         10)>]
[<InlineData(                                                             "onze",         11)>]
[<InlineData(                                                             "doze",         12)>]
[<InlineData(                                                            "treze",         13)>]
[<InlineData(                                                          "catorze",         14)>]
[<InlineData(                                                          "quatorze",        14)>]
[<InlineData(                                                            "quinze",        15)>]
[<InlineData(                                                         "dezesseis",        16)>]
[<InlineData(                                                         "dezessete",        17)>]
[<InlineData(                                                           "dezoito",        18)>]
[<InlineData(                                                          "dezenove",        19)>]
[<InlineData(                                                             "vinte",        20)>]
[<InlineData(                                                        "vinte e um",        21)>]
[<InlineData(                                                      "vinte e dois",        22)>]
[<InlineData(                                                      "vinte e três",        23)>]
[<InlineData(                                                    "vinte e quatro",        24)>]
[<InlineData(                                                     "vinte e cinco",        25)>]
[<InlineData(                                                      "vinte e seis",        26)>]
[<InlineData(                                                      "vinte e sete",        27)>]
[<InlineData(                                                      "vinte e oito",        28)>]
[<InlineData(                                                      "vinte e nove",        29)>]
[<InlineData(                                                            "trinta",        30)>]
[<InlineData(                                                   "trinta e quatro",        34)>]
[<InlineData(                                                          "quarenta",        40)>]
[<InlineData(                                                     "quarenta e um",        41)>]
[<InlineData(                                                         "cinquenta",        50)>]
[<InlineData(                                                         "cinqüenta",        50)>]
[<InlineData(                                                  "cinquenta e dois",        52)>]
[<InlineData(                                                  "cinqüenta e sete",        57)>]
[<InlineData(                                                          "sessenta",        60)>]
[<InlineData(                                                   "sessenta e dois",        62)>]
[<InlineData(                                                           "setenta",        70)>]
[<InlineData(                                                  "setenta e quatro",        74)>]
[<InlineData(                                                           "oitenta",        80)>]
[<InlineData(                                                   "oitenta e cinco",        85)>]
[<InlineData(                                                           "noventa",        90)>]
[<InlineData(                                                    "noventa e seis",        96)>]
[<InlineData(                                                               "cem",       100)>]
[<InlineData(                                                        "cento e um",       101)>]
[<InlineData(                                              "cento e vinte e seis",       126)>]
[<InlineData(                                                          "duzentos",       200)>]
[<InlineData(                                          "duzentos e trinta e sete",       237)>]
[<InlineData(                                                         "trezentos",       300)>]
[<InlineData(                                       "trezentos e setenta e cinco",       375)>]
[<InlineData(                                                      "quatrocentos",       400)>]
[<InlineData(                                            "quatrocentos e noventa",       490)>]
[<InlineData(                                                        "quinhentos",       500)>]
[<InlineData(                                      "quinhentos e sessenta e sete",       567)>]
[<InlineData(                                                        "seiscentos",       600)>]
[<InlineData(                                      "seiscentos e trinta e quatro",       634)>]
[<InlineData(                                                        "setecentos",       700)>]
[<InlineData(                                      "setecentos e quarenta e oito",       748)>]
[<InlineData(                                                        "oitocentos",       800)>]
[<InlineData(                                              "oitocentos e catorze",       814)>]
[<InlineData(                                                        "novecentos",       900)>]
[<InlineData(                                         "novecentos e setenta e um",       971)>]
[<InlineData(                                                               "mil",      1000)>]
[<InlineData(                                                          "mil e um",      1001)>]
[<InlineData(                                                        "mil e dois",      1002)>]
[<InlineData(                                           "mil e sessenta e quatro",      1064)>]
[<InlineData(                                                    "mil e duzentos",      1200)>]
[<InlineData(                                      "mil, duzentos e oitenta e um",      1281)>]
[<InlineData(                                                            "um mil",      1000)>]
[<InlineData(                                                          "dois mil",      2000)>]
[<InlineData(                                                          "três mil",      3000)>]
[<InlineData(                                                        "quatro mil",      4000)>]
[<InlineData(                                                         "cinco mil",      5000)>]
[<InlineData(                                                          "seis mil",      6000)>]
[<InlineData(                                                          "sete mil",      7000)>]
[<InlineData(                                 "oito mil, setecentos e vinte e um",      8721)>]
[<InlineData(                                    "nove mil, cento e vinte e três",      9123)>]
[<InlineData(                                                           "dez mil",     10000)>]
[<InlineData(                                               "dez mil, cento e um",     10101)>]
[<InlineData(                                             "dez mil, cento e dois",     10102)>]
[<InlineData(                                                          "onze mil",     11000)>]
[<InlineData(                                                          "doze mil",     12000)>]
[<InlineData(                                                         "treze mil",     13000)>]
[<InlineData(                                                      "quatorze mil",     14000)>]
[<InlineData(                                                       "catorze mil",     14000)>]
[<InlineData(                                                        "quinze mil",     15000)>]
[<InlineData(                                                     "dezesseis mil",     16000)>]
[<InlineData(                                                     "dezessete mil",     17000)>]
[<InlineData(                                                       "dezoito mil",     18000)>]
[<InlineData(                                                      "dezenove mil",     19000)>]
[<InlineData(                  "vinte e três mil, quinhentos e sessenta e quatro",     23564)>]
[<InlineData(                                                 "oitenta mil e dez",     80010)>]
[<InlineData(                                                           "cem mil",    100000)>]
[<InlineData(                                                      "cem mil e um",    100001)>]
[<InlineData(             "trezentos e dezenove mil, trezentos e quarenta e nove",    319349)>]
[<InlineData(                                                         "um milhão",   1000000)>]
[<InlineData(                                                    "um milhão e um",   1000001)>]
[<InlineData(                                                   "um milhão e cem",   1000100)>]
[<InlineData(                            "um milhão, trezentos e vinte mil e cem",   1320100)>]
[<InlineData(                 "um milhão, trezentos e vinte mil, trezentos e dez",   1320310)>]
[<InlineData(                                                "dois milhões e dez",   2000010)>]
[<InlineData(                                         "seis milhões e trinta mil",   6030000)>]
[<InlineData(             "nove milhões, duzentos e um mil, seiscentos e oitenta",   9201680)>]
[<InlineData(                                                       "dez milhões",  10000000)>]
[<InlineData(                                                "dez milhões e nove",  10000009)>]
[<InlineData(                                                "vinte e um milhões",  21000000)>]
[<InlineData("quarenta e sete milhões, seiscentos e sessenta e um mil e sessenta",  47661060)>]
[<InlineData(                                                       "cem milhões", 100000000)>]
[<InlineData(                                 "cem milhões, dois mil e trezentos", 100002300)>]
[<InlineData(                                          "duzentos e cinco milhões", 205000000)>]
[<InlineData(                                          "trezentos e sete milhões", 307000000)>]
[<InlineData(   "quatrocentos e sessenta e um milhões, sessenta mil e seiscentos", 461060600)>]
let ``tryParseBrazilian returns correct result`` (portuguese, expected) =
    let actual = Numeral.tryParseBrazilian portuguese
    Some expected =! actual
