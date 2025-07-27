import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails({ cohort }) {
  const titleStyle = {
    color:
      cohort.status.toLowerCase() === 'ongoing'
        ? 'green'
        : cohort.status.toLowerCase() === 'scheduled'
        ? 'blue'
        : 'black',
    fontWeight: 'bold'
  };

  return (
    <div className={styles.card}>
      <h3 style={titleStyle}>{cohort.name}</h3>
      <dl>
        <dt>Started On</dt>
        <dd>{cohort.startDate}</dd>

        <dt>Current Status</dt>
        <dd>{cohort.status}</dd>

        <dt>Coach</dt>
        <dd>{cohort.coach}</dd>

        <dt>Trainer</dt>
        <dd>{cohort.trainer}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;