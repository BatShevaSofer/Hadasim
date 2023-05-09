import React, { useState, useEffect } from "react";
import { Chart, Line, plugins } from "react-chartjs-2";

const Graph = ({ people }) => {
  const [data, setData] = useState([
    {
      x: "",
      y: 0,
    },
  ]);

  useEffect(() => {
    const ovulationDates = people.map(person => person.ovulationDate);
    const recoveryDates = people.map(person => person.recoveryDate);

    for (let i = 0; i < ovulationDates.length; i++) {
      const ovulationDate = ovulationDates[i];
      const recoveryDate = recoveryDates[i];

      if (ovulationDate && recoveryDate) {
        const days = Math.floor((recoveryDate - ovulationDate) / (1000 * 60 * 60 * 24));

        setData([
          ...data,
          {
            x: ovulationDate,
            y: days,
          },
        ]);
      }
    }
  }, [people]);

  return (
    <div>
      <Chart
        data={data}
        options={{
          scales: {
            x: {
              type: "category",
              ticks: {
                autoSkip: true,
              },
            },
            y: {
              type: "linear",
              position: "left",
              min: 0,
              max: 100,
            },
          },
          plugins: {
            tooltip: {
              enabled: true,
            },
          },
        }}
      >
        <Line
          dataKey="y"
        />
      </Chart>
    </div>
  );
};

export default Graph;