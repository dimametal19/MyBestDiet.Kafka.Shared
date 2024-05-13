using Confluent.Kafka;

namespace MyBestDiet.Kafka.Shared.Producer
{
    public class KafkaProducerConfig<Tk, Tv> : ProducerConfig
    {
        public string Topic { get; set; }
    }
}