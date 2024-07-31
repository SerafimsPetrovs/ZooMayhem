using System;
using System.Collections.Generic;

namespace ZooMayhem
{
    public static class NewsGenerator
    {
        private static Random _random = new Random();

        private static List<string> _starters = new List<string>
        {
            "It's vacation time and the city is expecting increased activity",
            "We interviewed a local resident today",
            "A major technological breakthrough has been announced",
            "A significant cultural event is unfolding in the city",
            "A surprising discovery has been made in the scientific community",
            "A new government policy is set to impact local businesses",
            "An international conference is being hosted in the city",
            "A popular tourist attraction is undergoing renovations",
            "A local charity event is raising funds for a good cause",
            "A natural disaster has struck a nearby region"
            
        };

        private static Dictionary<string, Tuple<List<string>, List<Tuple<string, List<string>>>>> _topics = new Dictionary<string, Tuple<List<string>, List<Tuple<string, List<string>>>>>
        {
            {
                "It's vacation time and the city is expecting increased activity",
                Tuple.Create(
                    new List<string>
                    {
                        "Many tourists are flocking to popular museums and landmarks",
                        "Will our city be able to accommodate such a large influx of visitors?",
                        "Local businesses are gearing up for a busy season",
                        "Public transportation is experiencing heavy congestion",
                        "Residents are concerned about the environmental impact",
                        "Tourists are enjoying local cuisine and shopping districts",
                        "Events promoting cultural exchange are scheduled throughout the city",
                        "Travel agencies report a surge in bookings for city tours"
                        
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("Increased tourism is boosting the local economy", new List<string>
                        {
                            "New job opportunities are opening up in the hospitality sector",
                            "Local artisans are experiencing increased demand for handmade souvenirs",
                            "Restaurants are introducing new dishes to cater to international tastes"
                        }),
                        Tuple.Create("Businesses are reporting record profits", new List<string>
                        {
                            "Investment in local businesses is on the rise",
                            "Real estate prices in tourist areas are climbing",
                            "Local museums are expanding their collections with new acquisitions"
                        }),
                        Tuple.Create("Traffic jams are causing frustration among commuters", new List<string>
                        {
                            "City officials are considering infrastructure improvements",
                            "Alternative transportation options are being explored",
                            "Residents are organizing carpools to reduce traffic congestion"
                        }),
                        Tuple.Create("The city's infrastructure is under strain", new List<string>
                        {
                            "Public works projects are being accelerated to address infrastructure needs",
                            "Environmental groups are advocating for sustainable urban planning",
                            "Local businesses are investing in eco-friendly initiatives"
                        })
                    }
                )
            },
            {
                "We interviewed a local resident today",
                Tuple.Create(
                    new List<string>
                    {
                        "Local opinions on recent city council decisions vary widely",
                        "Residents express concerns over rising housing costs",
                        "Community leaders are advocating for improved public services",
                        "Citizens are divided on a proposed urban development project",
                        "A resident shares their success story in overcoming adversity",
                        "A community initiative aims to beautify public spaces",
                        "A local artist describes their inspiration behind a new mural"
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("The interview has sparked a debate among policymakers", new List<string>
                        {
                            "City councilors are holding town hall meetings to address public concerns",
                            "Political candidates are discussing their positions on key issues",
                            "Community organizations are forming alliances to advocate for change"
                        }),
                        Tuple.Create("Social media is buzzing with reactions from residents", new List<string>
                        {
                            "Online petitions are circulating to push for policy reforms",
                            "Residents are organizing grassroots campaigns to raise awareness",
                            "Local media outlets are publishing editorials on community issues"
                        }),
                        Tuple.Create("City officials promise to address community concerns", new List<string>
                        {
                            "Task forces are being established to study housing affordability",
                            "Public forums are scheduled to gather citizen input on development projects",
                            "Elected officials are proposing legislation to improve public services"

                        }),
                        Tuple.Create("Residents are organizing a protest in response to the interview", new List<string>
                        {
                            "Demonstrations are planned to advocate for policy changes",
                            "Community leaders are meeting with government officials to negotiate",
                            "Legal experts are reviewing residents' rights to protest peacefully"
                        })
                    }
                )
            },
            {
                "A major technological breakthrough has been announced",
                Tuple.Create(
                    new List<string>
                    {
                        "Experts predict the breakthrough will revolutionize the industry",
                        "Investors are rushing to fund related startups",
                        "The technology promises to improve daily life for millions",
                        "Researchers share insights into the discovery process",
                        "The breakthrough is being hailed as a milestone in scientific history",
                        "Scientists discuss potential applications in space exploration"
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("Stock prices of tech companies involved have soared", new List<string>
                        {
                            "New startups are forming to capitalize on the breakthrough",
                            "Venture capitalists are increasing funding for tech innovation",
                            "Job openings in technology sectors are on the rise"
                        }),
                        Tuple.Create("Governments are discussing regulatory implications", new List<string>
                        {
                            "Legislators are drafting bills to regulate the new technology",
                            "Ethical guidelines for the technology's use are being debated",
                            "Public hearings are scheduled to gather citizen input on regulations"
                        }),
                        Tuple.Create("Public interest in STEM education has surged", new List<string>
                        {
                            "Schools are expanding STEM programs to meet demand",
                            "STEM scholarships are being established for students",
                            "Tech companies are offering internships to STEM graduates"
                        }),
                        Tuple.Create("Competing companies are racing to develop similar technologies", new List<string>
                        {
                            "Patent disputes between companies are escalating",
                            "Tech giants are acquiring smaller firms with similar technologies",
                            "Industry conferences are focusing on advancements in the field"
                        })
                    }
                )
            },
            {
                "A significant cultural event is unfolding in the city",
                Tuple.Create(
                    new List<string>
                    {
                        "Local artists are showcasing their work at the event",
                        "Visitors are experiencing a fusion of different cultures",
                        "Community groups are hosting workshops and performances",
                        "Historical sites are being highlighted during the event",
                        "International guests are attending to celebrate diversity",
                        "The event features a parade showcasing traditional costumes"
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("The event is boosting tourism and local business revenues", new List<string>
                        {
                            "Local hotels report full occupancy during the event",
                            "Restaurants are featuring special menus inspired by the cultures",
                            "Retail stores are seeing increased sales of cultural merchandise"
                        }),
                        Tuple.Create("Residents are proud of their city's cultural heritage", new List<string>
                        {
                            "Community pride events are planned to celebrate cultural diversity",
                            "Local schools incorporate event themes into their curriculum",
                            "City officials propose permanent cultural exhibits"
                        }),
                        Tuple.Create("Artists are gaining recognition on a global scale", new List<string>
                        {
                            "International art galleries express interest in showcasing local talent",
                            "Artists receive invitations to participate in global art festivals",
                            "Cultural exchange programs are established with other cities"
                        }),
                        Tuple.Create("The event is fostering cultural exchange and understanding", new List<string>
                        {
                            "Cross-cultural dialogues continue beyond the event",
                            "Community centers launch cultural exchange programs",
                            "Local media outlets promote stories of cultural integration"
                        })
                    }
                )
            },
            {
                "A surprising discovery has been made in the scientific community",
                Tuple.Create(
                    new List<string>
                    {
                        "Researchers have uncovered evidence of a new species",
                        "New findings challenge existing theories in physics",
                        "A breakthrough in medical research offers hope for treatments",
                        "Scientists have developed a more efficient renewable energy technology",
                        "Astronomers have detected signals from a distant galaxy",
                        "Marine biologists discover a new ecosystem in deep ocean trenches"
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("The discovery is attracting international attention", new List<string>
                        {
                            "Leading scientific journals feature the discovery on their covers",
                            "Research institutions invite lead scientists to present their findings",
                            "Public lectures on the discovery are sold out"
                        }),
                        Tuple.Create("Funding for further research has been secured", new List<string>
                        {
                            "Government grants are allocated to expand research on the discovery",
                            "Private donors contribute to establish research endowments",
                            "Research teams expand to include international collaborators"
                        }),
                        Tuple.Create("Educational institutions are revising their curricula", new List<string>
                        {
                            "New courses focusing on the discovery are introduced",
                            "Students engage in hands-on research projects related to the discovery",
                            "Science fairs feature exhibits based on the new findings"
                        }),
                        Tuple.Create("Public interest in science and innovation has surged", new List<string>
                        {
                            "Science museums organize exhibits dedicated to the discovery",
                            "Public forums discuss the implications of the discovery on society",
                            "Science-themed TV programs feature documentaries on the discovery"
                        })
                    }
                )
            },
            {
                "A new government policy is set to impact local businesses",
                Tuple.Create(
                    new List<string>
                    {
                        "Small businesses express concerns over increased regulations",
                        "New incentives are being offered to promote green initiatives",
                        "The policy aims to support startups and entrepreneurship",
                        "Industries are adjusting their strategies in response to the policy",
                        "Government officials outline benefits and challenges of the new policy",
                        "Business associations are lobbying for amendments to the policy"
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("Businesses are exploring new opportunities for growth", new List<string>
                        {
                            "Tech startups receive grants to develop sustainable technologies",
                            "Local manufacturers pivot to produce eco-friendly products",
                            "Consulting firms offer services to help businesses comply with the policy"
                        }),
                        Tuple.Create("The policy is expected to create jobs in emerging sectors", new List<string>
                        {
                            "Training programs are launched to prepare workers for new job roles",
                            "Entrepreneurs establish startups to capitalize on policy incentives",
                            "Job fairs prioritize hiring for green and sustainable businesses"
                        }),
                        Tuple.Create("Environmental organizations applaud the government's initiative", new List<string>
                        {
                            "Environmental groups partner with businesses to promote sustainable practices",
                            "Public awareness campaigns educate consumers on the policy's benefits",
                            "Green certifications become a marketing advantage for businesses"
                        }),
                        Tuple.Create("Public debates highlight varying perspectives on the policy", new List<string>
                        {
                            "Media outlets host panel discussions on the policy's impact",
                            "Community forums gather feedback from stakeholders",
                            "Policy forums invite experts to analyze the policy's long-term effects"
                        })
                    }
                )
            },
            {
                "An international conference is being hosted in the city",
                Tuple.Create(
                    new List<string>
                    {
                        "World leaders gather to discuss global challenges",
                        "Researchers present groundbreaking discoveries at the conference",
                        "Participants engage in cross-cultural dialogues and collaborations",
                        "Local businesses showcase innovative technologies and products",
                        "The conference features keynote speeches from influential figures",
                        "Academic institutions host pre-conference workshops and seminars"
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("The conference boosts the city's reputation as a global hub", new List<string>
                        {
                            "International media coverage highlights the city's achievements",
                            "Tourism agencies promote the city as a conference destination",
                            "The city government launches initiatives to attract future conferences"
                        }),
                        Tuple.Create("Local hospitality industry sees a surge in bookings", new List<string>
                        {
                            "Hotels report full occupancy during the conference",
                            "Restaurants and bars experience increased patronage",
                            "Tour operators offer specialized tours for conference attendees"
                        }),
                        Tuple.Create("International partnerships are forged during the conference", new List<string>
                        {
                            "Business collaborations result in joint ventures and investments",
                            "Research institutions establish long-term research partnerships",
                            "Diplomatic discussions lead to international agreements"
                        }),
                        Tuple.Create("The city experiences an influx of visitors from around the world", new List<string>
                        {
                            "Local shops see a boost in sales of souvenirs and local products",
                            "Public transportation services extend hours to accommodate visitors",
                            "Cultural events are organized to showcase the city's heritage"
                        })
                    }
                )
            },
            {
                "A popular tourist attraction is undergoing renovations",
                Tuple.Create(
                    new List<string>
                    {
                        "Visitors express disappointment over temporary closure",
                        "New features and exhibits are planned for the attraction",
                        "The renovations aim to enhance visitor experience and safety",
                        "Local businesses anticipate a decline in tourist footfall",
                        "Residents discuss the historical significance of the attraction",
                        "Architects unveil plans for sustainable design elements"
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("The attraction's reopening generates excitement among visitors", new List<string>
                        {
                            "Media coverage highlights the attraction's new features",
                            "VIP tours and events are organized for reopening day",
                            "Special discounts attract locals and tourists alike"
                        }),
                        Tuple.Create("Renovations stimulate economic growth in the surrounding area", new List<string>
                        {
                            "Local contractors and suppliers benefit from renovation contracts",
                            "New businesses open near the attraction to cater to visitors",
                            "Property values in the area appreciate due to increased tourism"
                        }),
                        Tuple.Create("Tourism authorities promote alternative attractions during closure", new List<string>
                        {
                            "Guided tours of nearby historical sites are offered",
                            "Special events are organized to keep tourists engaged",
                            "Local businesses collaborate to offer package deals"
                        }),
                        Tuple.Create("Public feedback influences final design decisions", new List<string>
                        {
                            "Community surveys gather input on attraction improvements",
                            "Public meetings address concerns and suggestions",
                            "Architects adjust plans based on visitor preferences"
                        })
                    }
                )
            },
            {
                "A local charity event is raising funds for a good cause",
                Tuple.Create(
                    new List<string>
                    {
                        "Community volunteers organize fundraising activities",
                        "Celebrities show their support for the charity event",
                        "Participants share personal stories of impact and inspiration",
                        "Local businesses sponsor the charity event",
                        "The event highlights the importance of philanthropy",
                        "Volunteers prepare care packages for those in need"
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("The charity event exceeds fundraising goals", new List<string>
                        {
                            "Donations pour in from online and offline sources",
                            "Corporate sponsors pledge additional funds",
                            "Fundraising efforts inspire similar events in neighboring communities"
                        }),
                        Tuple.Create("Funds raised contribute to meaningful community projects", new List<string>
                        {
                            "New community center construction begins",
                            "Scholarships are established for local students",
                            "Medical equipment is purchased for a local hospital"
                        }),
                        Tuple.Create("Volunteers receive recognition for their efforts", new List<string>
                        {
                            "Local media profiles outstanding volunteers",
                            "Community awards are presented at a recognition ceremony",
                            "Volunteer recruitment for future events increases"
                        }),
                        Tuple.Create("Media coverage raises awareness about the cause", new List<string>
                        {
                            "Public support for the charity increases",
                            "Government officials pledge support for related initiatives",
                            "Awareness campaigns lead to policy changes"
                        })
                    }
                )
            },
            {
                "A natural disaster has struck a nearby region",
                Tuple.Create(
                    new List<string>
                    {
                        "Emergency response teams mobilize to provide aid",
                        "Residents evacuate to safety as the disaster unfolds",
                        "Local shelters and relief centers are established",
                        "Authorities issue warnings and safety advisories",
                        "Volunteers offer support and assistance to affected families",
                        "Community members organize donation drives"
                    },
                    new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("International aid organizations coordinate relief efforts", new List<string>
                        {
                            "Emergency supplies are airlifted to the disaster zone",
                            "Medical teams from neighboring countries arrive to provide assistance",
                            "Temporary housing solutions are implemented for displaced families"
                        }),
                        Tuple.Create("Communities come together to rebuild homes and infrastructure", new List<string>
                        {
                            "Volunteer teams assist with debris removal and cleanup",
                            "Construction companies offer pro bono services for rebuilding",
                            "Fundraising campaigns raise money for long-term recovery"
                        }),
                        Tuple.Create("The disaster sparks discussions on preparedness and resilience", new List<string>
                        {
                            "Government agencies review disaster response protocols",
                            "Community workshops educate residents on emergency preparedness",
                            "Public forums address climate change and its impact on natural disasters"
                        }),
                        Tuple.Create("The international community pledges long-term support", new List<string>
                        {
                            "Global organizations commit to sustainable development projects",
                            "Long-term recovery plans prioritize environmental sustainability",
                            "Scholarships are offered to students affected by the disaster"
                        })
                    }
                )
            }
        };

        public static News GenerateRandomNewsObject(Main mainForm)
        {
            string starter = _starters[_random.Next(_starters.Count)];

            var topicDetails = _topics[starter];
            List<string> eventOptions = topicDetails.Item1;
            List<Tuple<string, List<string>>> consequenceOptions = topicDetails.Item2;

            string content = starter + ".\n";

            int numEvents = _random.Next(2, 5);
            HashSet<string> usedEvents = new HashSet<string>();
            HashSet<string> usedConsequences = new HashSet<string>();

            for (int i = 0; i < numEvents; i++)
            {
                string eventText;
                do
                {
                    eventText = eventOptions[_random.Next(eventOptions.Count)];
                } while (usedEvents.Contains(eventText));
                usedEvents.Add(eventText);

                Tuple<string, List<string>> consequenceTuple;
                do
                {
                    consequenceTuple = consequenceOptions[_random.Next(consequenceOptions.Count)];
                } while (usedConsequences.Contains(consequenceTuple.Item1));
                usedConsequences.Add(consequenceTuple.Item1);

                string consequenceText = consequenceTuple.Item1;

                content += $"{eventText}. {consequenceText}.\n";
            }

            return new News(mainForm, content);
        }
    }
}